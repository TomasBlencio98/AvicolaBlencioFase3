using ProyectoAvicola.Entidades.Dtos;
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
    public partial class LocalidadesMenu : Form
    {
        private readonly ServicioLocalidades servicioLocalidades;
        private List<Localidad> listaLocalidades;
        public LocalidadesMenu()
        {
            InitializeComponent();
            servicioLocalidades = new ServicioLocalidades();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarLocalidadesEnGrilla();
        }

        private void MostrarLocalidadesEnGrilla()
        {
            listaLocalidades = servicioLocalidades.GetLocalidades();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaLocalidades);
        }

        private void TsbButtonAgregar_Click(object sender, EventArgs e)
        {
            LocalidadesAE frm = new LocalidadesAE();
            frm.Text = "Agregar Localidad";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var localidad = frm.GetLocalidad();
                if (!servicioLocalidades.Existe(localidad))
                {
                    servicioLocalidades.Guardar(localidad);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, localidad);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    MostrarLocalidadesEnGrilla();
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

        private void TsbButtonEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            Localidad localidad = (Localidad)r.Tag;
            Localidad localidadCopia = (Localidad)localidad.Clone();
            try
            {
                LocalidadesAE frm = new LocalidadesAE() { Text = "Editar Localidad" };
                frm.SetLocalidad(localidad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
                localidad = frm.GetLocalidad();
                if (!servicioLocalidades.Existe(localidad))
                {
                    servicioLocalidades.Guardar(localidad);
                    GridHelpers.SetearFila(r, localidad);
                    MostrarLocalidadesEnGrilla();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, localidadCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, localidadCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbButtonBorrar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            Localidad localidad = (Localidad)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($"¿Desea borrar la localidad {localidad.NombreLocalidad}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioLocalidades.Borrar(localidad.LocalidadId);
                GridHelpers.QuitarFila(DgvDatos, r);
                MostrarLocalidadesEnGrilla();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar porque este registro " +
                    "esta relacionado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
