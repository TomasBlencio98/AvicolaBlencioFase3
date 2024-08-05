using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioDetalleGalpon_Alimentos
    {
        void AgregarDetalleGalponAlimento
            (DetalleGalpon_Alimento detalleGalponAlimento);
    }
}
