using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Datos.Repositorios;
using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;

namespace ProyectoAvicola.Servicios.Servicios
{
    public class ServicioGranjas : IServicioGranjas
    {
        private readonly IRepositorioGranjas repositorioGranjas;
        private readonly IRepositorioGalpones repositorioGalpones;
        private readonly IRepositorioEmpleados repositorioEmpleados;
        private readonly IRepositorioProveedores repositorioProveedores;
        public ServicioGranjas()
        {
            repositorioGranjas = new RepositorioGranjas();
            repositorioGalpones = new RepositorioGalpones();
            repositorioEmpleados = new RepositorioEmpleados();
            repositorioProveedores = new RepositorioProveedores();
        }
        public void Borrar(int GranjaId)
        {
            try
            {
                repositorioGranjas.Borrar(GranjaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Granja granja)
        {
            try
            {
                return repositorioGranjas.Existe(granja);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            try
            {
                return repositorioGranjas.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GranjaDto> GetGranjas()
        {
            try
            {
                var listaGranjas = repositorioGranjas.GetGranjas();
                foreach (var granja in listaGranjas)
                {
                    granja.NumeroDeGalpones = repositorioGalpones
                        .GetCantidadGalponesPorGranja(granja.GranjaId);
                    granja.NumeroDeEmpleados = repositorioEmpleados
                        .GetCantidadEmpleadosPorGranja(granja.GranjaId);
                    granja.NumeroDeProveedores = repositorioProveedores
                        .GetCantidadProveedoresPorGranja(granja.GranjaId);
                }
                return listaGranjas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Granja GetGranjasPorId(int GranjaId)
        {
            try
            {
                return repositorioGranjas.GetGranjasPorId(GranjaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Granja Granja)
        {
            try
            {
                if (Granja.GranjaId == 0)
                {
                    repositorioGranjas.Agregar(Granja);
                }
                else
                {
                    repositorioGranjas.Editar(Granja);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
