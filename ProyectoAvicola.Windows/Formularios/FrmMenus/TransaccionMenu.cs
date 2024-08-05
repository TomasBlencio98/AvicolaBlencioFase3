using ProyectoAvicola.Datos.Repositorios;
using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class TransaccionMenu : Form
    {
        private readonly ServicioTransacciones servicioTransacciones;
        private readonly ServicioProveedores servicioProveedores;
        private List<TransaccionDto> listaTransacciones = new List<TransaccionDto>();
        public TransaccionMenu()
        {
            InitializeComponent();
            servicioTransacciones=new ServicioTransacciones();
            servicioProveedores=new ServicioProveedores();  
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBoxs.CargarComboProveedores(ref ComboBoxProveedores);
            ComboBoxs.CargarComboAlimentos(ref comboBoxAlimento);
            ComboBoxs.CargarComboMedicamentos(ref comboBoxMedicamentos);
        }

        private void buttonAceptarAlimentos_Click(object sender, EventArgs e)
        {
            if (comboBoxAlimento.SelectedItem != null && numericUpDownCantidadAlimentos.Value > 0)
            {
                var alimento = (Alimento)comboBoxAlimento.SelectedItem;
                var cantidad = (int)numericUpDownCantidadAlimentos.Value;
                AgregarOActualizarTransaccionDto("Alimento", alimento.TipoAlimento, cantidad,alimento.AlimentoId);
            }
            else
            {
                MessageBox.Show("Seleccione un alimento y una cantidad " +
                    "válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarOActualizarTransaccionDto(string tipo, string nombre, int cantidad,int itemId)
        {
            var itemExistente = listaTransacciones.FirstOrDefault(item => item.Tipo == tipo && item.Nombre == nombre);
            if (itemExistente != null)
            {
                itemExistente.Cantidad += cantidad;
            }
            else
            {
                var nuevoItem = new TransaccionDto
                {
                    itemId=itemId,
                    Tipo = tipo,
                    Nombre = nombre,
                    Cantidad = cantidad
                };
                listaTransacciones.Add(nuevoItem);
            }
            MostrarTransaccionesEnGrilla();
        }

        private void MostrarTransaccionesEnGrilla()
        {
            GridHelpers.LimpiarGrilla(DgvDatos);
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaTransacciones);
        }

        private void buttonAceptarMedicamentos_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicamentos.SelectedItem != null && numericUpDownCantidadMedicamentos.Value > 0)
            {
                var medicamento = (Medicamento)comboBoxMedicamentos.SelectedItem;
                var cantidad = (int)numericUpDownCantidadMedicamentos.Value;
                AgregarOActualizarTransaccionDto("Medicamento", medicamento.TipoMedicamento, cantidad,medicamento.MedicamentoId);
            }
            else
            {
                MessageBox.Show("Seleccione un medicamento y una cantidad " +
                    "válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            var item = (TransaccionDto)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($"¿Desea borrar el producto {item.Nombre}?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                listaTransacciones.Remove(item);
                GridHelpers.QuitarFila(DgvDatos, r);
                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var proveedordto = (ProveedorDto)ComboBoxProveedores.SelectedItem;
                var proveedor = servicioProveedores.GetProveedorPorId(proveedordto.ProveedorId);
                var transaccion = new Transaccion
                {
                    ProveedorId = proveedor.ProveedorId,
                    Fecha = dateTimePickerFecha.Value
                };
                try
                {
                    servicioTransacciones.GuardarTransaccion(transaccion, listaTransacciones);
                    MessageBox.Show("Transacción guardada exitosamente."
                        , "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar la transacción: "
                        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (ComboBoxProveedores.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un proveedor.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val= false;
            }
            if (listaTransacciones.Count == 0)
            {
                MessageBox.Show("Agregue al menos un alimento o medicamento a la transacción.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val = false;
            }
            return val;
        }

    }
}
