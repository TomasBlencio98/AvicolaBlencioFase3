using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioTransacciones
    {
        List<TransaccionDto> GetDetallesTransaccion(int transaccionId);
        List<TransaccionHistorial> GetTransacciones();
        Transaccion GetTransaccionPorId(int transaccionId);
        void GuardarTransaccion(Transaccion transaccion,
            List<TransaccionDto> listaTransacciones);
    }
}
