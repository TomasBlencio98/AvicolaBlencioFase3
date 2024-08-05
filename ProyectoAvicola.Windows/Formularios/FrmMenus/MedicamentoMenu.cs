using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.FrmAE;
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

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class MedicamentoMenu : Form
    {
        private readonly ServicioMedicamentos servicioMedicamentos;
        private List<Medicamento> listaMedicamentos;
        public MedicamentoMenu()
        {
            InitializeComponent();
            servicioMedicamentos=new ServicioMedicamentos();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarMedicamentosEnGrilla();
        }

        private void MostrarMedicamentosEnGrilla()
        {
            listaMedicamentos = servicioMedicamentos.GetMedicamentos();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaMedicamentos);
        }

        private void TsbButtonAgregar_Click(object sender, EventArgs e)
        {
            MedicamentosAE frm = new MedicamentosAE();
            frm.Text = "Agregar Medicamento";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var medicamento = frm.GetMedicamento();
                if (!servicioMedicamentos.Existe(medicamento))
                {
                    servicioMedicamentos.Guardar(medicamento);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, medicamento);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    MostrarMedicamentosEnGrilla();
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
            Medicamento medicamento = (Medicamento)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($"¿Desea borrar el medicamento {medicamento.TipoMedicamento}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioMedicamentos.Borrar(medicamento.MedicamentoId);
                GridHelpers.QuitarFila(DgvDatos, r);
                MostrarMedicamentosEnGrilla();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo borrar el registro " +
                    "porque esta relacionado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbButtonEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            Medicamento medicamento = (Medicamento)r.Tag;
            Medicamento medicamentoCopia = (Medicamento)medicamento.Clone();
            try
            {
                MedicamentosAE frm = new MedicamentosAE() { Text = "Editar Medicamento" };
                frm.SetMedicamento(medicamento);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                medicamento = frm.GetMedicamento();
                if (!servicioMedicamentos.Existe(medicamento))
                {
                    servicioMedicamentos.Guardar(medicamento);
                    GridHelpers.SetearFila(r, medicamento);
                    MostrarMedicamentosEnGrilla();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, medicamentoCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, medicamentoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
