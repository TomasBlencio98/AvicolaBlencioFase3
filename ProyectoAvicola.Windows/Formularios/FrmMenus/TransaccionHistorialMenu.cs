using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Helpers;

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class TransaccionHistorialMenu : Form
    {
        private readonly IServicioTransacciones servicioTransacciones;
        public TransaccionHistorialMenu()
        {
            InitializeComponent();
            servicioTransacciones = new ServicioTransacciones();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarTransaccionesEnGrilla();
        }

        private void MostrarTransaccionesEnGrilla()
        {
            var listaTransacciones = servicioTransacciones.GetTransacciones();
            GridHelpers.MostrarDatosEnGrilla(DgvDatosTransacciones, listaTransacciones);
        }

        private void TsbButtonDetalles_Click(object sender, EventArgs e)
        {
            if (DgvDatosTransacciones.SelectedRows.Count == 0) return;
            var r = DgvDatosTransacciones.SelectedRows[0];
            TransaccionHistorial t = (TransaccionHistorial)r.Tag;
            Transaccion transaccion = servicioTransacciones.GetTransaccionPorId(t.transaccionId);
            List<TransaccionDto> listaDetalles = servicioTransacciones.GetDetallesTransaccion(transaccion.TransaccionId);
            GridHelpers.MostrarDatosEnGrilla(DgvDatosDetalles, listaDetalles);
        }
        private void TsbButtonActualizar_Click_2(object sender, EventArgs e)
        {
            GridHelpers.LimpiarGrilla(DgvDatosDetalles);
        }
    }
}
