using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioDetalle_Galpones
    {
        void Agregar(Detalle_Galpon detalleGalpon);
        void Borrar(int detalleGalponId);
        void Editar(Detalle_Galpon detalleGalpon);
        bool ExisteDetalleGalponSinFechaEgreso(int galponId);
        Detalle_Galpon GetDetalleGalponesPorId(int detalleGalponId);
    }
}
