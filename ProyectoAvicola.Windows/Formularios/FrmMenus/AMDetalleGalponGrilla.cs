using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Helpers;

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class AMDetalleGalponGrilla : Form
    {
        private readonly ServicioAlimentos servicioAlimentos;
        private readonly ServicioMedicamentos servicioMedicamentos;
        private int detalleGalponId;
        private int mostrar = 0;
        private List<AlimentoDto> listaAlimento;
        private List<MedicamentoDto> listaMedicamento;
        public AMDetalleGalponGrilla(int detalleGalponId, int mostrar)
        {
            InitializeComponent();
            this.detalleGalponId = detalleGalponId;
            this.mostrar = mostrar;
            servicioAlimentos = new ServicioAlimentos();
            servicioMedicamentos = new ServicioMedicamentos();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (mostrar==2)
            {
                listaAlimento=servicioAlimentos.GetAlimentosPorDetalleGalponId(detalleGalponId);
                GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaAlimento);
            }
            else if (mostrar==1)
            {
                listaMedicamento = servicioMedicamentos.GetMedicamentosPorDetalleGalponId(detalleGalponId);
                GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaMedicamento);
            }
            
        }
    }
}
