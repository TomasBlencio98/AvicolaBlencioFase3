using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioProveedores
    {
        void Agregar(Proveedor proveedor);
        void Borrar(int ProveedorId);
        void Editar(Proveedor proveedor);
        int GetCantidad();
        List<ProveedorDto> GetProveedores();
        bool Existe(Proveedor proveedor);
        Proveedor GetProveedorPorId(int proveedorId);
        int GetCantidadProveedoresPorGranja(int granjaId);
        int GetCantidadGranjasPorProveedor(int proveedorId);
        List<Granja> GetGranjasPorProveedor(int proveedorId);
        bool ExisteRelacion(int proveedorId, int granjaId);
        void AsignarGranjaAProveedor(int proveedorId, int granjaId);
        void QuitarGranjaDeProveedor(int proveedorId, int granjaId);
    }
}
