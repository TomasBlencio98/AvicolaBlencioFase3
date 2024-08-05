using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    public partial class DetalleCantMedicamento : Form
    {
        private int detalleGalponId;
        private DetalleGalpon_Medicamento dGM;
        public DetalleCantMedicamento(int detalleGalponId)
        {
            InitializeComponent();
            this.detalleGalponId = detalleGalponId;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBoxs.CargarComboMedicamentos(ref ComboBoxMedicamento);
        }
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                dGM = new DetalleGalpon_Medicamento
                {
                    DetalleGalponId = detalleGalponId,
                    MedicamentoId = (int)ComboBoxMedicamento.SelectedValue,
                    Cantidad = int.Parse(TextBoxCantidadMedi.Text),
                    Fecha = DateTime.Now
                };
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (string.IsNullOrEmpty(TextBoxCantidadMedi.Text))
            {
                errorProvider1.SetError(TextBoxCantidadMedi,
                    "Cantidad mal ingresado!!!");
                val = false;
            }
            if (ComboBoxMedicamento.SelectedIndex == 0)
            {
                errorProvider1.SetError(ComboBoxMedicamento, "Debe seleccionar un medicamento");
                val = false;
            }
            return val;
        }

        public DetalleGalpon_Medicamento GetDgM()
        {
            return dGM;
        }
    }
}
