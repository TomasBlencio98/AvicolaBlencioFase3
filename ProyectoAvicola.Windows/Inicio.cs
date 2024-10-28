using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.FrmMenus;
using ProyectoAvicola.Windows.Helpers;

namespace ProyectoAvicola.Windows
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            servicioGranjas = new ServicioGranjas();
        }
        private readonly ServicioGranjas servicioGranjas;
        private List<GranjaDto> listaGranjas;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listaGranjas = servicioGranjas.GetGranjas();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaGranjas);
        }
        //asd
        private void TsbButtonEmpleados_Click(object sender, EventArgs e)
        {
            EmpleadosMenu frm = new EmpleadosMenu();
            frm.Show(this);
        }

        private void TsbButtonProveedores_Click(object sender, EventArgs e)
        {
            ProveedoresMenu frm = new ProveedoresMenu();
            frm.Show(this);
        }

        private void TsbButtonActualizar_Click(object sender, EventArgs e)
        {
            listaGranjas = servicioGranjas.GetGranjas();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaGranjas);
        }

        private void TsbButtonLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesMenu frm = new LocalidadesMenu();
            frm.Show(this);
        }

        private void TsbButtonAlimento_Click(object sender, EventArgs e)
        {
            AlimentosMenu frm = new AlimentosMenu();
            frm.Show(this);
        }

        private void TsbButtonMedicamento_Click(object sender, EventArgs e)
        {
            MedicamentoMenu frm = new MedicamentoMenu();
            frm.Show(this);
        }

        private void nuevaTransaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaccionMenu frm = new TransaccionMenu();
            frm.Show(this);
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TransaccionHistorialMenu();
            frm.Show(this);
        }

        private void TsbButtonGalpon_Click(object sender, EventArgs e)
        {
            var frm = new GalponesMenu();
            frm.Show(this);
        }

        private void TsbButtonDetalleGranja_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            GranjaDto granjaDto = (GranjaDto)r.Tag;
            Granja granja = servicioGranjas.GetGranjasPorId(granjaDto.GranjaId);
            GalponesXGranjaMenu frm = new GalponesXGranjaMenu(granja);
            frm.Show(this);
        }
    }
}
