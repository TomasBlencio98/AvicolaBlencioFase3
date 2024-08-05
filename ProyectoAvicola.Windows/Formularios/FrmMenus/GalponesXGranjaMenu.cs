using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
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

namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    public partial class GalponesXGranjaMenu : Form
    {
        private readonly ServicioGalpones servicioGalpones;
        private List<GalponDto> listaGalpones;
        private Granja granja;
        public GalponesXGranjaMenu(Granja g)
        {
            InitializeComponent();
            servicioGalpones = new ServicioGalpones();
            this.granja = g;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listaGalpones = servicioGalpones.GetGalponesPorGranjaId(granja.GranjaId);
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaGalpones);
        }

        private void TsbButtonDetalleGalpon_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            var r = DgvDatos.SelectedRows[0];
            GalponDto galponDto = (GalponDto)r.Tag;
            Galpon galpon = servicioGalpones.GetGalponesPorId(galponDto.GalponId);
            DetalleGalponMenu frm = new DetalleGalponMenu(galpon,granja);
            frm.Show(this);
        }
    }
}
