using Dapper;
using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Repositorios
{
    public class RepositorioDetalleGalpon_Medicamentos 
        : IRepositorioDetalleGalpon_Medicamentos
    {
        private readonly string cadenaConexion;
        public RepositorioDetalleGalpon_Medicamentos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void AgregarDetalleGalponMedicamento
            (DetalleGalpon_Medicamento detalleGalponMedicamento)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO DetalleGalpon_Medicamento 
                               (DetalleGalponId, MedicamentoId, Cantidad, Fecha) 
                               VALUES (@DetalleGalponId, @MedicamentoId, @Cantidad, @Fecha); 
                               SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, detalleGalponMedicamento);
                detalleGalponMedicamento.DetalleGalponMedicamentoId = id;
            }
        }
    }
}
