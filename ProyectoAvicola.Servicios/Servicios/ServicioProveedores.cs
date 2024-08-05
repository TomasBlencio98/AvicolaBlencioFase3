using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Datos.Repositorios;
using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Servicios
{
    public class ServicioProveedores : IServicioProveedores
    {
        private readonly IRepositorioProveedores repositorioProveedores;
        public ServicioProveedores()
        {
            repositorioProveedores = new RepositorioProveedores();
        }

        public void AsignarGranjaAProveedor(int proveedorId, int granjaId)
        {
            try
            {
                if (!repositorioProveedores.ExisteRelacion(proveedorId, granjaId))
                {
                    repositorioProveedores.AsignarGranjaAProveedor(proveedorId, granjaId);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Borrar(int ProveedorId)
        {
            try
            {
                repositorioProveedores.Borrar(ProveedorId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            try
            {
                return repositorioProveedores.Existe(proveedor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ExisteRelacion(int proveedorId, int granjaId)
        {
            return repositorioProveedores.ExisteRelacion(proveedorId, granjaId);
        }

        public int GetCantidad()
        {
            throw new NotImplementedException();
        }

        public List<Granja> GetGranjasPorProveedor(int proveedorId)
        {
            return repositorioProveedores.GetGranjasPorProveedor(proveedorId);
        }

        public List<ProveedorDto> GetProveedores()
        {
            try
            {
                var listaProveedores = repositorioProveedores.GetProveedores();
                foreach (var proveedor in listaProveedores)
                {
                    proveedor.GranjasAsociadas = repositorioProveedores
                        .GetCantidadGranjasPorProveedor(proveedor.ProveedorId);
                }
                return listaProveedores;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Proveedor GetProveedorPorId(int proveedorId)
        {
            try
            {
                return repositorioProveedores.GetProveedorPorId(proveedorId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Proveedor proveedor)
        {
            try
            {
                if (proveedor.ProveedorId == 0)
                {
                    repositorioProveedores.Agregar(proveedor);
                }
                else
                {
                    repositorioProveedores.Editar(proveedor);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void QuitarGranjaDeProveedor(int proveedorId, int granjaId)
        {
            repositorioProveedores.QuitarGranjaDeProveedor(proveedorId, granjaId);
        }
    }
}
