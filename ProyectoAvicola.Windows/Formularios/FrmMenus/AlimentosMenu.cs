using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.Alimentos;
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
    public partial class AlimentosMenu : Form
    {
        private readonly ServicioAlimentos servicioAlimentos;
        private List<Alimento> listaAlimentos;
        public AlimentosMenu()
        {
            InitializeComponent();
            servicioAlimentos = new ServicioAlimentos();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarAlimentosEnGrilla();
        }

        private void MostrarAlimentosEnGrilla()
        {
            listaAlimentos = servicioAlimentos.GetAlimentos();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaAlimentos);
        }

        private void TsbButtonAgregar_Click(object sender, EventArgs e)
        {
            AlimentosAE frm = new AlimentosAE();
            frm.Text = "Agregar Alimento";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var alimento = frm.GetAlimento();
                if (!servicioAlimentos.Existe(alimento))
                {
                    servicioAlimentos.Guardar(alimento);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, alimento);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    MostrarAlimentosEnGrilla();
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
            Alimento alimento = (Alimento)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($"¿Desea borrar el alimento {alimento.TipoAlimento}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioAlimentos.Borrar(alimento.AlimentoId);
                GridHelpers.QuitarFila(DgvDatos, r);
                MostrarAlimentosEnGrilla();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo borrar el registro porque " +
                    "se encuantra relacionado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbButtonEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            Alimento alimento = (Alimento)r.Tag;
            Alimento alimentoCopia = (Alimento)alimento.Clone();
            try
            {
                AlimentosAE frm = new AlimentosAE() { Text = "Editar Alimento" };
                frm.SetAlimento(alimento);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                alimento = frm.GetAlimento();
                if (!servicioAlimentos.Existe(alimento))
                {
                    servicioAlimentos.Guardar(alimento);
                    GridHelpers.SetearFila(r, alimento);
                    MostrarAlimentosEnGrilla();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, alimentoCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, alimentoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
