using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Servicios;
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

namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    public partial class AsignarGranja_Proveedor : Form
    {
        private readonly ServicioProveedores servicioProveedores;
        private Proveedor proveedor;
        public AsignarGranja_Proveedor(Proveedor proveedor)
        {
            InitializeComponent();
            servicioProveedores = new ServicioProveedores();
            this.proveedor = proveedor;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBoxs.CargarComboGranjas(ref ComboBoxGranjas);
            var granjasAsignadas = servicioProveedores.GetGranjasPorProveedor(proveedor.ProveedorId);
            ListBoxGranjasAsociadas.DataSource = granjasAsignadas;
            ListBoxGranjasAsociadas.DisplayMember = "NombreGranja";
            TexBoxProveedor.Text = $"{proveedor.ApellidoProveedor}, {proveedor.NombreProveedor}";
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            var granjaId = (int)ComboBoxGranjas.SelectedValue;

            if (!servicioProveedores.ExisteRelacion(proveedor.ProveedorId, granjaId))
            {
                servicioProveedores.AsignarGranjaAProveedor(proveedor.ProveedorId, granjaId);
                MessageBox.Show("Granja asignada correctamente.");
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("La relación entre la granja y el proveedor ya existe.");
            }
        }

        private void ActualizarListBox()
        {
            var granjasAsignadas = servicioProveedores.GetGranjasPorProveedor(proveedor.ProveedorId);
            ListBoxGranjasAsociadas.DataSource = granjasAsignadas;
            ListBoxGranjasAsociadas.DisplayMember = "NombreGranja";
        }

        private void ButtonSacarGranja_Click(object sender, EventArgs e)
        {
            if (ListBoxGranjasAsociadas.SelectedItem != null)
            {
                var granja = (Granja)ListBoxGranjasAsociadas.SelectedItem;
                servicioProveedores.QuitarGranjaDeProveedor(proveedor.ProveedorId, granja.GranjaId);
                MessageBox.Show("Granja eliminada correctamente.");
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("Seleccione una granja de la lista.");
            }
        }
    }
}
