using ProyectoAvicola.Entidades.Entidades;
using System.Windows.Forms;

namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    public partial class DetalleCantMortalidad : Form
    {
        private int dgId;
        public DetalleCantMortalidad(int detalleGalponId)
        {
            InitializeComponent();
            dgId = detalleGalponId;
        }
        private Mortalidad mortalidad;
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                mortalidad=new Mortalidad();
                mortalidad.Cantidad = int.Parse(TextBoxMortalidad.Text);
                mortalidad.Fecha = DateTime.Now;
                mortalidad.DetalleGalponId = dgId;
                DialogResult = DialogResult.OK;
            }
            else
            {
                errorProvider1.SetError(ButtonAceptar,
                    "Error!!!");
            }
            
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (string.IsNullOrEmpty(TextBoxMortalidad.Text))
            {
                errorProvider1.SetError(TextBoxMortalidad,
                    "Cantidad mal ingresada!!!");
                val = false;
            }
            return val;
        }

        public Mortalidad GetMortalidad()
        {
            return mortalidad;
        }
    }
}
