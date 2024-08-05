using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioMortalidades
    {
        void AgregarMortalidad(Mortalidad mortalidad);
        int GetTotalMuertosPorDetalleGalpon(int detalleGalponId);
    }
}
