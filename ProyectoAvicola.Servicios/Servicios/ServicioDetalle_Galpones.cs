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
    public class ServicioDetalle_Galpones : IServicioDetalle_Galpones
    {
        private readonly IRepositorioDetalle_Galpones repoDetalleGalpones;
        public ServicioDetalle_Galpones()
        {
            repoDetalleGalpones=new RepositorioDetalle_Galpones();
        }
        public void Borrar(int detalleGalponId)
        {
            try
            {
                repoDetalleGalpones.Borrar(detalleGalponId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ExisteDetalleGalponSinFechaEgreso(int galponId)
        {
            try
            {
                return repoDetalleGalpones.ExisteDetalleGalponSinFechaEgreso(galponId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Detalle_Galpon GetDetalleGalponesPorId(int detalleGalponId)
        {
            try
            {
                return repoDetalleGalpones.GetDetalleGalponesPorId(detalleGalponId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Detalle_Galpon detalleGalpon)
        {
            try
            {
                if (detalleGalpon.DetalleGalponId == 0)
                {
                    repoDetalleGalpones.Agregar(detalleGalpon);
                }
                else
                {
                    repoDetalleGalpones.Editar(detalleGalpon);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
