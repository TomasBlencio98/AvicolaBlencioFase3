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
    public class RepositorioMortalidades : IRepositorioMortalidades
    {
        private readonly string cadenaConexion;
        public RepositorioMortalidades()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void AgregarMortalidad(Mortalidad mortalidad)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Mortalidad (DetalleGalponId, Cantidad, Fecha) 
                                   VALUES (@DetalleGalponId, @Cantidad, @Fecha);
                                   SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, mortalidad);
                mortalidad.MortalidadId = id;
            }
        }

        public int GetTotalMuertosPorDetalleGalpon(int detalleGalponId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"SELECT ISNULL(SUM(Cantidad), 0) FROM Mortalidad WHERE DetalleGalponId = @DetalleGalponId";
                return conn.QuerySingle<int>(query, new { DetalleGalponId = detalleGalponId });
            }
        }
    }
}
