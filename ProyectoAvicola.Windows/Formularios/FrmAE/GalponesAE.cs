using ProyectoAvicola.Entidades.Entidades;
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
using System.Windows.Forms.VisualStyles;

namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    public partial class GalponesAE : Form
    {
        public GalponesAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBoxs.CargarComboGranjas(ref ComboBoxGranjas);
            if (galpon != null)
            {
                TextBoxCapacidad.Text = galpon.Capacidad.ToString();
                ComboBoxGranjas.SelectedValue = galpon.GranjaId;
            }
        }

        public Galpon GetGalpon()
        {
            return galpon;
        }

        private Galpon galpon;

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (galpon == null)
                {
                    galpon = new Galpon();
                }
                galpon.NombreGalpon = TexBoxNombreGalpon.Text;
                galpon.Capacidad = int.Parse(TextBoxCapacidad.Text);
                galpon.GranjaId = (int)ComboBoxGranjas.SelectedValue;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (!int.TryParse(TextBoxCapacidad.Text, out int resultado) || resultado<=0)
            {
                errorProvider1.SetError(TextBoxCapacidad,
                    "Capacidad mal ingresada!!!");
                val = false;
            }
            if (ComboBoxGranjas.SelectedIndex == 0)
            {
                errorProvider1.SetError(ComboBoxGranjas, "Debe seleccionar una Granja");
                val = false;
            }
            if (string.IsNullOrEmpty(TexBoxNombreGalpon.Text))
            {
                errorProvider1.SetError(TexBoxNombreGalpon, "Debe ingresar un valor para este campo");
                val = false;
            }
            return val;
        }

        public void SetGalpon(Galpon galpon)
        {
            this.galpon= galpon;
        }
    }
}
