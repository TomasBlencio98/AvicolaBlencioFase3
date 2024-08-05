using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioDetalle_Galpones
    {
        void Guardar(Detalle_Galpon detalleGalpon);
        void Borrar(int detalleGalponId);
        bool ExisteDetalleGalponSinFechaEgreso(int galponId);
        Detalle_Galpon GetDetalleGalponesPorId(int detalleGalponId);
    }
}
