using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    public partial class DetalleGalponAE : Form
    {
        private Granja granja;
        private Galpon galpon;
        private Detalle_Galpon detalleGalpon;
        private readonly ServicioDetalle_Galpones servicioDetalleGalpones;
        public DetalleGalponAE(Granja granja, Galpon galpon)
        {
            InitializeComponent();
            this.granja = granja;
            this.galpon = galpon;
            servicioDetalleGalpones = new ServicioDetalle_Galpones();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TexBoxGalpon.Text = galpon.NombreGalpon;
            TextBoxCapacidad.Text = galpon.Capacidad.ToString();
            if (detalleGalpon!=null)
            {
                TexboxIngresoCant.Text = detalleGalpon.TotalIngreso.ToString();
                DtpFechaIngreso.Text = detalleGalpon.FechaIngreso.ToString();
            }
        }
        public Detalle_Galpon GetDetalleGalpon()
        {
            return detalleGalpon;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            
            if (ValidarDatos())
            {
                bool result;
                if (detalleGalpon == null)
                {
                    detalleGalpon = new Detalle_Galpon() {
                    GalponId = galpon.GalponId,
                    FechaHoy = DateTime.Now,
                    FechaIngreso = DtpFechaIngreso.Value,
                    TotalIngreso = int.Parse(TexboxIngresoCant.Text)};
                    result = servicioDetalleGalpones.ExisteDetalleGalponSinFechaEgreso(detalleGalpon.GalponId);
                    if (result)
                    {
                        MessageBox.Show("No podemos agregar un nuevo detalle galpon, ya que" +
                        "el galpon seleccionado posee pollitos dentro, todavia no fue liberado" +
                        ". Seleccione otro galpon que este disponible.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    detalleGalpon.GalponId = galpon.GalponId;
                    detalleGalpon.FechaHoy = DateTime.Now;
                    detalleGalpon.FechaIngreso = DtpFechaIngreso.Value;
                    detalleGalpon.TotalIngreso = int.Parse(TexboxIngresoCant.Text);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (!int.TryParse(TexboxIngresoCant.Text, out int resultado) || resultado <= 0)
            {
                errorProvider1.SetError(TexboxIngresoCant, "Total ingreso mal ingresado!!!");
                val = false;
            }
            if (resultado >= galpon.Capacidad)
            {
                errorProvider1.SetError(TexboxIngresoCant, "Total ingreso " +
                    "mal ingresado, no puede ser mayor a la capacidad del galpon!!!");
                val = false;
            }
            if (DtpFechaIngreso.Value < DateTime.Today)
            {
                errorProvider1.SetError(DtpFechaIngreso, "La fecha de ingreso debe ser mayor a la fecha de hoy.");
                val = false;
            }
            return val;
        }

        public void SetDetalleGalpon(Detalle_Galpon detalleGalpon)
        {
            this.detalleGalpon = detalleGalpon;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
