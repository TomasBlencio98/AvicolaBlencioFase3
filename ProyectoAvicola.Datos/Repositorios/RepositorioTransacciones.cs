using Dapper;
using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoAvicola.Datos.Repositorios
{
    public class RepositorioTransacciones : IRepositorioTransacciones
    {
        private readonly string cadenaConexion;
        public RepositorioTransacciones()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public List<TransaccionDto> GetDetallesTransaccion(int transaccionId)
        {
            List<TransaccionDto> detalles = new List<TransaccionDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string alimentosQuery = @"SELECT 'Alimento' AS Tipo, a.TipoAlimento AS Nombre, ta.Cantidad 
                        FROM Transaccion_Alimento ta
                        JOIN Alimento a ON ta.AlimentoId = a.AlimentoId
                        WHERE ta.TransaccionId = @TransaccionId";
                var alimentos = conn.Query<TransaccionDto>(alimentosQuery, new { TransaccionId = transaccionId }).ToList();
                detalles.AddRange(alimentos);
                string medicamentosQuery = @"SELECT 'Medicamento' AS Tipo, m.TipoMedicamento AS Nombre, tm.Cantidad 
                        FROM Transaccion_Medicamento tm
                        JOIN Medicamento m ON tm.MedicamentoId = m.MedicamentoId
                        WHERE tm.TransaccionId = @TransaccionId";
                var medicamentos = conn.Query<TransaccionDto>(medicamentosQuery, new { TransaccionId = transaccionId }).ToList();
                detalles.AddRange(medicamentos);
            }
            return detalles;
        }

        public List<TransaccionHistorial> GetTransacciones()
        {
            using (var connection = new SqlConnection(cadenaConexion))
            {
                var sql = @"
                SELECT t.TransaccionId, t.Fecha, p.NombreProveedor
                FROM Transaccion t
                INNER JOIN Proveedor p ON t.ProveedorId = p.ProveedorId";

                var transacciones = connection.Query<TransaccionHistorial>(sql).ToList();
                return transacciones;
            }
        }

        public Transaccion GetTransaccionPorId(int transaccionId)
        {
            Transaccion transaccion = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT TransaccionId, ProveedorId, Fecha 
                               FROM Transaccion 
                               WHERE TransaccionId = @TransaccionId";
                transaccion = conn.QuerySingleOrDefault<Transaccion>(selectQuery, new { TransaccionId = transaccionId });
            }
            return transaccion;
        }

        public void GuardarTransaccion(Transaccion transaccion)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Transaccion (ProveedorId, Fecha) 
                                   VALUES (@ProveedorId, @Fecha);
                                   SELECT SCOPE_IDENTITY()";
                transaccion.TransaccionId = conn.QuerySingle<int>(insertQuery, transaccion);
            }
        }

        public void GuardarTransaccionAlimento(Transaccion_Alimento transaccionAlimento)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Transaccion_Alimento (TransaccionId, AlimentoId, Cantidad) 
                                   VALUES (@TransaccionId, @AlimentoId, @Cantidad)";
                conn.Execute(insertQuery, transaccionAlimento);
            }
        }

        public void GuardarTransaccionMedicamento(Transaccion_Medicamento transaccionMedicamento)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Transaccion_Medicamento (TransaccionId, MedicamentoId, Cantidad) 
                                   VALUES (@TransaccionId, @MedicamentoId, @Cantidad)";
                conn.Execute(insertQuery, transaccionMedicamento);
            }
        }

    }
}
