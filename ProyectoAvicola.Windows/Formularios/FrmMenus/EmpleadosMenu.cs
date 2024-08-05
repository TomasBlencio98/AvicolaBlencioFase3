using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.FrmAE;
using ProyectoAvicola.Windows.Helpers;

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class EmpleadosMenu : Form
    {
        private readonly ServicioEmpleados servicioEmpleados;
        private List<EmpleadoDto> listaEmpleados;
        public EmpleadosMenu()
        {
            InitializeComponent();
            servicioEmpleados = new ServicioEmpleados();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarEmpleadosEnGrilla();
        }

        private void TsbButtonBorrar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            EmpleadoDto empleadoDto = r.Tag as EmpleadoDto;
            Empleado empleado = servicioEmpleados.GetEmpleadosPorId(empleadoDto.EmpleadoId);
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioEmpleados.Borrar(empleado.EmpleadoId);
                GridHelpers.QuitarFila(DgvDatos, r);
                MostrarEmpleadosEnGrilla();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al intentar borrar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEmpleadosEnGrilla()
        {
            listaEmpleados = servicioEmpleados.GetEmpleados();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaEmpleados);
        }

        private void TsbButtonAgregar_Click(object sender, EventArgs e)
        {
            EmpleadosAE frm = new EmpleadosAE();
            frm.Text = "Agregar Empleado";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var empleado = frm.GetEmpleado();
                if (!servicioEmpleados.Existe(empleado))
                {
                    servicioEmpleados.Guardar(empleado);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, empleado);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    MostrarEmpleadosEnGrilla();
                    MessageBox.Show("Registro agregado correctamente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TsbButtonEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            EmpleadoDto empleadoDto = (EmpleadoDto)r.Tag;
            Empleado empleado = servicioEmpleados.GetEmpleadosPorId(empleadoDto.EmpleadoId);
            Empleado empleadoCopia = (Empleado)empleado.Clone();
            try
            {
                EmpleadosAE frm = new EmpleadosAE() { Text = "Editar Empleado" };
                frm.SetEmpleado(empleado);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                empleado = frm.GetEmpleado();
                if (!servicioEmpleados.Existe(empleado))
                {
                    servicioEmpleados.Guardar(empleado);
                    GridHelpers.SetearFila(r, empleado);
                    MostrarEmpleadosEnGrilla();
                    MessageBox.Show("Registro editado correctamente", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, empleadoCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, empleadoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
