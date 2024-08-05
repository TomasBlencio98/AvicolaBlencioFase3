using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioTransacciones
    {
        void GuardarTransaccion(Transaccion transaccion);
        void GuardarTransaccionAlimento(Transaccion_Alimento transaccionAlimento);
        void GuardarTransaccionMedicamento(Transaccion_Medicamento transaccionMedicamento);
        List<TransaccionHistorial> GetTransacciones();
        Transaccion GetTransaccionPorId(int transaccionId);
        List<TransaccionDto> GetDetallesTransaccion(int transaccionId);
    }
}
