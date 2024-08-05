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

namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    public partial class DetalleCantAlimento : Form
    {
        private int detalleGalponId;
        private DetalleGalpon_Alimento dGA;
        public DetalleCantAlimento(int detalleGalponId)
        {
            InitializeComponent();
            this.detalleGalponId = detalleGalponId;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBoxs.CargarComboAlimentos(ref ComboBoxAlimento);
        }

        public DetalleGalpon_Alimento GetDga()
        {
            return dGA;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                dGA = new DetalleGalpon_Alimento
                {
                    DetalleGalponId=detalleGalponId,
                    AlimentoId= (int)ComboBoxAlimento.SelectedValue,
                    Cantidad=int.Parse(TextBoxCantidadAlimento.Text),
                    Fecha=DateTime.Now
                };
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (string.IsNullOrEmpty(TextBoxCantidadAlimento.Text))
            {
                errorProvider1.SetError(TextBoxCantidadAlimento,
                    "Cantidad mal ingresado!!!");
                val = false;
            }
            if (ComboBoxAlimento.SelectedIndex == 0)
            {
                errorProvider1.SetError(ComboBoxAlimento, "Debe seleccionar un alimento");
                val = false;
            }
            return val;
        }
    }
}
