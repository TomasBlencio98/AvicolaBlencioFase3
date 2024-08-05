using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.FrmAE;
using ProyectoAvicola.Windows.Helpers;
using System.Drawing;

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class DetalleGalponMenu : Form
    {
        private readonly ServicioGalpones servicioGalpones;
        private readonly ServicioDetalle_Galpones servicioDetalleGalpones;
        private readonly ServicioMortalidades servicioMortalidades;
        private readonly ServicioDetalleGalpon_Alimentos sDGA;
        private readonly ServicioDetalleGalpon_Medicamentos sDGM;
        private Galpon galpon;
        private Granja granja;
        private int detalleGalponId;
        public DetalleGalponMenu(Galpon g, Granja gr)
        {
            InitializeComponent();
            servicioGalpones = new ServicioGalpones();
            servicioDetalleGalpones = new ServicioDetalle_Galpones();
            servicioMortalidades = new ServicioMortalidades();
            sDGA=new ServicioDetalleGalpon_Alimentos();
            sDGM=new ServicioDetalleGalpon_Medicamentos();
            galpon = g;
            granja = gr;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarGalponesEnGrilla();
        }
        private void DesabilitarFilasLoad()
        {
            foreach (DataGridViewRow row in DgvDatos.Rows)
            {
                var detalleGalponId = (int)row.Cells["ColumnaDetalleGalponId"].Value;
                var detalleGalpon = servicioDetalleGalpones.GetDetalleGalponesPorId(detalleGalponId);
                if (detalleGalpon.FechaEgreso != DateTime.MinValue)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell is DataGridViewButtonCell buttonCell 
                            && row.DataGridView.Columns[cell.ColumnIndex].Name != "ColumnaVerAlimentos"
                            && row.DataGridView.Columns[cell.ColumnIndex].Name != "ColumnaVerMedicamentos")
                        {
                            buttonCell.Value = "Desactivado";
                        }
                    }
                }
            }
        }

        private void MostrarGalponesEnGrilla()
        {
            List<DetalleGalponDto> galpons = servicioGalpones.GetDetalleGalpon(galpon.GalponId);
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, galpons);
            DesabilitarFilasLoad();
            ActualizarMuertes();
        }

        private void ActualizarMuertes()
        {
            int fila = 0;
            var detallesGalpones = servicioGalpones.GetDetalleGalpon(galpon.GalponId);
            foreach (var detalleGalpon in detallesGalpones)
            {
                int totalMuertos = servicioMortalidades.GetTotalMuertosPorDetalleGalpon
                    (detalleGalpon.DetalleGalponId);
                int pollitosVivos = detalleGalpon.TotalIngreso - totalMuertos;
                DgvDatos.Rows[fila].Cells[9].Value = totalMuertos;
                DgvDatos.Rows[fila].Cells[10].Value = pollitosVivos;
                fila++;
            }
        }

        private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                detalleGalponId = (int)DgvDatos.Rows[e.RowIndex].Cells["ColumnaDetalleGalponId"].Value;
                if (e.ColumnIndex == DgvDatos.Columns["ColumnaMortalidad"].Index)
                {
                    AgregarMortalidad(detalleGalponId);
                }
                else if (e.ColumnIndex == DgvDatos.Columns["ColumnaMedicamento"].Index)
                { 
                    AgregarMedicamentos(detalleGalponId);
                }
                else if (e.ColumnIndex == DgvDatos.Columns["ColumnaAlimento"].Index)
                {
                    AgregarAlimentos(detalleGalponId);
                }
                else if (e.ColumnIndex == DgvDatos.Columns["ColumnaFinalizar"].Index)
                {
                    FinalizarDetalleGalpon(detalleGalponId);
                }
                else if (e.ColumnIndex == DgvDatos.Columns["ColumnaVerAlimentos"].Index)
                {
                    VerAlimentosDetalleGalpon(detalleGalponId);
                }
                else if (e.ColumnIndex == DgvDatos.Columns["ColumnaVerMedicamentos"].Index)
                {
                    VerMedicamentosDetalleGalpon(detalleGalponId);
                }
            }
        }
        int mostrar = 0;

        private void VerMedicamentosDetalleGalpon(int detalleGalponId)
        {
            mostrar = 1;
            AMDetalleGalponGrilla frm = new AMDetalleGalponGrilla(detalleGalponId,mostrar);
            frm.Show(this);
        }

        private void VerAlimentosDetalleGalpon(int detalleGalponId)
        {
            mostrar = 2;
            AMDetalleGalponGrilla frm= new AMDetalleGalponGrilla(detalleGalponId,mostrar);
            frm.Show(this);
        }

        private void FinalizarDetalleGalpon(int detalleGalponId)
        {
            var dg = servicioDetalleGalpones.GetDetalleGalponesPorId(detalleGalponId);
            if (dg.FechaEgreso != DateTime.MinValue)
            {
                return;
            }
            Detalle_Galpon a = servicioDetalleGalpones
                .GetDetalleGalponesPorId(detalleGalponId);
            a.FechaEgreso = DateTime.Now;
            servicioDetalleGalpones.Guardar(a);
            MostrarGalponesEnGrilla();
            MessageBox.Show("Finalizado!!!", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AgregarMedicamentos(int detalleGalponId)
        {
            var dg = servicioDetalleGalpones.GetDetalleGalponesPorId(detalleGalponId);
            if (dg.FechaEgreso != DateTime.MinValue)
            {
                return;
            }
            DetalleCantMedicamento frm = new DetalleCantMedicamento(detalleGalponId);
            frm.Text = "Agregar Medicamentos";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                DetalleGalpon_Medicamento dgM = frm.GetDgM();
                sDGM.AgregarDetalleGalponMedicamento(dgM);
                MessageBox.Show("Medicamento agregado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgregarAlimentos(int detalleGalponId)
        {
            var dg = servicioDetalleGalpones.GetDetalleGalponesPorId(detalleGalponId);
            if (dg.FechaEgreso != DateTime.MinValue)
            {
                return;
            }
            DetalleCantAlimento frm= new DetalleCantAlimento(detalleGalponId);
            frm.Text = "Agregar alimentos";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                DetalleGalpon_Alimento dgA = frm.GetDga();
                sDGA.AgregarDetalleGalponAlimento(dgA);
                MessageBox.Show("Alimento agregado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgregarMortalidad(int detalleGalponId)
        {
            var dg = servicioDetalleGalpones.GetDetalleGalponesPorId(detalleGalponId);
            if (dg.FechaEgreso != DateTime.MinValue)
            {
                return;
            }
            DetalleCantMortalidad frm = new DetalleCantMortalidad(detalleGalponId);
            frm.Text = "Agregar mortalidad";
            DialogResult dt= frm.ShowDialog(this);
            if (dt == DialogResult.OK)
            {
                Mortalidad mortalidad = frm.GetMortalidad();
                servicioMortalidades.AgregarMortalidad(mortalidad);
                MessageBox.Show("Mortalidad agregada", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MostrarGalponesEnGrilla();
        }

        private void TsbButtonNuevoDetalleGalpon_Click(object sender, EventArgs e)
        {
            DetalleGalponAE frm = new DetalleGalponAE(granja, galpon);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var detalleGalpon = frm.GetDetalleGalpon();
                servicioDetalleGalpones.Guardar(detalleGalpon);
                DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                GridHelpers.SetearFila(r, detalleGalpon);
                GridHelpers.AgregarFila(DgvDatos, r);
                MostrarGalponesEnGrilla();
                DesabilitarFilasLoad();
                MessageBox.Show("Registro agregado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TsbButtonBorrar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            DetalleGalponDto detalleGalponDto = (DetalleGalponDto)r.Tag;
            Detalle_Galpon detalleGalpon = servicioDetalleGalpones.GetDetalleGalponesPorId(detalleGalponDto.DetalleGalponId);
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioDetalleGalpones.Borrar(detalleGalpon.DetalleGalponId);
                GridHelpers.QuitarFila(DgvDatos, r);
                MostrarGalponesEnGrilla();
                DesabilitarFilasLoad();
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
            DetalleGalponDto detalleGalponDto = (DetalleGalponDto)r.Tag;
            Detalle_Galpon detalleGalpon = servicioDetalleGalpones.GetDetalleGalponesPorId(detalleGalponDto.DetalleGalponId);
            Detalle_Galpon detalleCopia = (Detalle_Galpon)detalleGalpon.Clone();
            try
            {
                DetalleGalponAE frm = new DetalleGalponAE(granja,galpon);
                frm.SetDetalleGalpon(detalleGalpon);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                detalleGalpon = frm.GetDetalleGalpon();
                servicioDetalleGalpones.Guardar(detalleGalpon);
                GridHelpers.SetearFila(r, galpon);
                MostrarGalponesEnGrilla();
                DesabilitarFilasLoad();
                MessageBox.Show("Registro editado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, detalleCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
