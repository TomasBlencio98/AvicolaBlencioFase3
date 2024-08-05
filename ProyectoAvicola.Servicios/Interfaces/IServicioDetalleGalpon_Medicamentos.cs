using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioDetalleGalpon_Medicamentos
    {
        void AgregarDetalleGalponMedicamento
            (DetalleGalpon_Medicamento detalleGalponMedicamento);
    }
}
