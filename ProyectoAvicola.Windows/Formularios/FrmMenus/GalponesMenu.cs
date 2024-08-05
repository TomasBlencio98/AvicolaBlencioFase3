using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.FrmAE;
using ProyectoAvicola.Windows.Helpers;

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class GalponesMenu : Form
    {
        private readonly ServicioGalpones servicioGalpones;
        private List<GalponDto> listaGalpones;
        public GalponesMenu()
        {
            InitializeComponent();
            servicioGalpones = new ServicioGalpones();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarGolponesEnGrilla();
        }

        private void MostrarGolponesEnGrilla()
        {
            listaGalpones = servicioGalpones.GetGalpones();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaGalpones);
        }

        private void TsbButtonAgregar_Click(object sender, EventArgs e)
        {
            GalponesAE frm = new GalponesAE();
            frm.Text = "Agregar Galpon";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var galpon = frm.GetGalpon();
                if (!servicioGalpones.Existe(galpon))
                {
                    servicioGalpones.Guardar(galpon);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, galpon);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    MostrarGolponesEnGrilla();
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TsbButtonBorrar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            GalponDto galponDto = (GalponDto)r.Tag;
            Galpon galpon = servicioGalpones.GetGalponesPorId(galponDto.GalponId);
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioGalpones.Borrar(galpon.GranjaId);
                GridHelpers.QuitarFila(DgvDatos, r);
                MostrarGolponesEnGrilla();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Registro relacionado!!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbButtonEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            GalponDto galponDto = (GalponDto)r.Tag;
            Galpon galpon = servicioGalpones.GetGalponesPorId(galponDto.GalponId);
            Galpon galponCopia = (Galpon)galpon.Clone();
            try
            {
                GalponesAE frm = new GalponesAE() { Text = "Editar Galpon" };
                frm.SetGalpon(galpon);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                galpon = frm.GetGalpon();
                if (!servicioGalpones.Existe(galpon))
                {
                    servicioGalpones.Guardar(galpon);
                    GridHelpers.SetearFila(r, galpon);
                    MostrarGolponesEnGrilla();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, galponCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, galponCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
