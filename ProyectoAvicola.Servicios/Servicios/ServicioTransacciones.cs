using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Datos.Repositorios;
using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using System.Transactions;

namespace ProyectoAvicola.Servicios.Servicios
{
    public class ServicioTransacciones : IServicioTransacciones
    {
        private readonly IRepositorioTransacciones repoTransacciones;
        public ServicioTransacciones()
        {
            repoTransacciones=new RepositorioTransacciones();
        }

        public List<TransaccionDto> GetDetallesTransaccion(int transaccionId)
        {
            return repoTransacciones.GetDetallesTransaccion(transaccionId);
        }

        public List<TransaccionHistorial> GetTransacciones()
        {
            try
            {
                return repoTransacciones.GetTransacciones();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Transaccion GetTransaccionPorId(int transaccionId)
        {
            return repoTransacciones.GetTransaccionPorId(transaccionId);
        }

        public void GuardarTransaccion(Transaccion transaccion,
            List<TransaccionDto> listaTransacciones)
        {
            using (var transaction = new TransactionScope())
            {
                repoTransacciones.GuardarTransaccion(transaccion);
                foreach (var item in listaTransacciones)
                {
                    if (item.Tipo == "Alimento")
                    {
                        var transaccionAlimento = new Transaccion_Alimento
                        {
                            TransaccionId = transaccion.TransaccionId,
                            AlimentoId = item.itemId,
                            Cantidad = item.Cantidad
                        };
                        repoTransacciones.GuardarTransaccionAlimento(transaccionAlimento);
                    }
                    else if (item.Tipo == "Medicamento")
                    {
                        var transaccionMedicamento = new Transaccion_Medicamento
                        {
                            TransaccionId = transaccion.TransaccionId,
                            MedicamentoId = item.itemId,
                            Cantidad = item.Cantidad
                        };
                        repoTransacciones.GuardarTransaccionMedicamento(transaccionMedicamento);
                    }
                }
                transaction.Complete();
            }
        }


    }
}
