using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Datos.Repositorios;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Servicios
{
    public class ServicioMortalidades : IServicioMortalidades
    {
        private readonly IRepositorioMortalidades repositorioMortalidades;
        public ServicioMortalidades()
        {
            repositorioMortalidades=new RepositorioMortalidades();
        }
        public void AgregarMortalidad(Mortalidad mortalidad)
        {
            try
            {
                repositorioMortalidades.AgregarMortalidad(mortalidad);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetTotalMuertosPorDetalleGalpon(int detalleGalponId)
        {
            try
            {
                return repositorioMortalidades.
                    GetTotalMuertosPorDetalleGalpon(detalleGalponId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
