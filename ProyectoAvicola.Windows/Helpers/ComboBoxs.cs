using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;

namespace ProyectoAvicola.Windows.Helpers
{
    public static class ComboBoxs
    {
        public static void CargarComboLocalidades(ref ComboBox combo)
        {
            IServicioLocalidades serviciosLocalidades = new ServicioLocalidades();
            var lista = serviciosLocalidades.GetLocalidades();
            var defaultLocalidad = new Localidad()
            {
                LocalidadId = 0,
                NombreLocalidad = "Seleccione Localidad"
            };
            lista.Insert(0, defaultLocalidad);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreLocalidad";
            combo.ValueMember = "LocalidadId";
            combo.SelectedIndex = 0;
        }
        public static void CargarComboGranjas(ref ComboBox combo)
        {
            IServicioGranjas servicioGranjas = new ServicioGranjas();
            var lista=servicioGranjas.GetGranjas();
            var defaultGranja = new GranjaDto()
            {
                GranjaId = 0,
                NombreGranja = "Seleccione Granja",
            };
            lista.Insert(0, defaultGranja);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreGranja";
            combo.ValueMember = "GranjaId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboProveedores(ref ComboBox combo)
        {
            IServicioProveedores servicioProveedores = new ServicioProveedores();
            var lista = servicioProveedores.GetProveedores();
            var defaultProveedor = new ProveedorDto()
            {
                ProveedorId = 0,
                NombreProveedor = "Seleccione Proveedor"
            };
            lista.Insert(0, defaultProveedor);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreProveedor";
            combo.ValueMember = "ProveedorId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboAlimentos(ref ComboBox combo)
        {
            IServicioAlimentos servicioAlimentos = new ServicioAlimentos();
            var lista = servicioAlimentos.GetAlimentos();
            var defaultAlimento = new Alimento()
            {
                AlimentoId = 0,
                TipoAlimento = "Seleccione Alimento"
            };
            lista.Insert(0, defaultAlimento);
            combo.DataSource = lista;
            combo.DisplayMember = "TipoAlimento";
            combo.ValueMember = "AlimentoId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboMedicamentos(ref ComboBox combo)
        {
            IServicioMedicamentos servicioMedicamentos = new ServicioMedicamentos();
            var lista = servicioMedicamentos.GetMedicamentos();
            var defaultMedicamento = new Medicamento()
            {
                MedicamentoId = 0,
                TipoMedicamento = "Seleccione Medicamento"
            };
            lista.Insert(0, defaultMedicamento);
            combo.DataSource = lista;
            combo.DisplayMember = "TipoMedicamento";
            combo.ValueMember = "MedicamentoId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboGalpones(ref ComboBox combo, int granjaId)
        {
            IServicioGalpones servicioGalpones = new ServicioGalpones();
            var lista = servicioGalpones.GetGalponesPorGranjaId(granjaId);

            var defaultGalpon = new GalponDto()
            {
                GalponId = 0,
                NombreGalpon = "Seleccione Galpon",
            };
            lista.Insert(0, defaultGalpon);

            combo.DataSource = lista;
            combo.DisplayMember = "NombreGalpon";
            combo.ValueMember = "GalponId";
            combo.SelectedIndex = 0;
        }

    }
}
