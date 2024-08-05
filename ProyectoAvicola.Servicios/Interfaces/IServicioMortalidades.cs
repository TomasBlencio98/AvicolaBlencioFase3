using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioMortalidades
    {
        void AgregarMortalidad(Mortalidad mortalidad);
        int GetTotalMuertosPorDetalleGalpon(int detalleGalponId);
    }
}
