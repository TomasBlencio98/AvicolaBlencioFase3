using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.FrmAE;
using ProyectoAvicola.Windows.Helpers;

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class ProveedoresMenu : Form
    {
        private readonly ServicioProveedores servicioProveedores;
        private List<ProveedorDto> listaProveedores;
        public ProveedoresMenu()
        {
            InitializeComponent();
            servicioProveedores = new ServicioProveedores();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarProveedoresEnGrilla();
        }

        private void MostrarProveedoresEnGrilla()
        {
            listaProveedores = servicioProveedores.GetProveedores();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaProveedores);
        }

        private void TsbButtonAsignarGranja_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            ProveedorDto proveedorDto = (ProveedorDto)r.Tag;
            Proveedor proveedor = servicioProveedores.GetProveedorPorId(proveedorDto.ProveedorId);

            AsignarGranja_Proveedor frm = new AsignarGranja_Proveedor(proveedor);
            frm.ShowDialog();
        }

        private void TsbButtonActualizar_Click(object sender, EventArgs e)
        {
            MostrarProveedoresEnGrilla();
        }

        private void TsbButtonAgregar_Click(object sender, EventArgs e)
        {
            ProveedorAE frm = new ProveedorAE();
            frm.Text = "Agregar Proveedor";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var proveedor = frm.GetProveedor();
                if (!servicioProveedores.Existe(proveedor))
                {
                    servicioProveedores.Guardar(proveedor);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, proveedor);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    MostrarProveedoresEnGrilla();
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
            ProveedorDto proveedorDto = (ProveedorDto)r.Tag;
            Proveedor proveedor = servicioProveedores.GetProveedorPorId(proveedorDto.ProveedorId);
            try
            {
                DialogResult dr = MessageBox.Show($"¿Desea borrar el proveedor {proveedor.NombreProveedor}, {proveedor.ApellidoProveedor}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioProveedores.Borrar(proveedor.ProveedorId);
                GridHelpers.QuitarFila(DgvDatos, r);
                MostrarProveedoresEnGrilla();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede borrar el registro porque" +
                    " esté se encuentra relacionado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbButtonEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            ProveedorDto proveedorDto = (ProveedorDto)r.Tag;
            Proveedor proveedor = servicioProveedores.GetProveedorPorId(proveedorDto.ProveedorId);
            Proveedor proveedorCopia = (Proveedor)proveedor.Clone();
            try
            {
                ProveedorAE frm = new ProveedorAE() { Text = "Editar Proveedor" };
                frm.SetProveedor(proveedor);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                proveedor = frm.GetProveedor();
                if (!servicioProveedores.Existe(proveedor))
                {
                    servicioProveedores.Guardar(proveedor);
                    GridHelpers.SetearFila(r, proveedor);
                    MostrarProveedoresEnGrilla();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, proveedorCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, proveedorCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
