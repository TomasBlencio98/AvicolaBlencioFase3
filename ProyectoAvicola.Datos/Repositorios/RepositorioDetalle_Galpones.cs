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
    public class RepositorioDetalle_Galpones : IRepositorioDetalle_Galpones
    {
        private readonly string cadenaConexion;
        public RepositorioDetalle_Galpones()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Detalle_Galpon detalleGalpon)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Detalle_Galpon 
                                   (GalponId, FechaHoy, FechaIngreso, TotalIngreso) 
                                   VALUES (@GalponId, @FechaHoy, @FechaIngreso, @TotalIngreso); 
                                   SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, detalleGalpon);
                detalleGalpon.DetalleGalponId = id;
            }
        }

        public void Borrar(int detalleGalponId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Detalle_Galpon WHERE DetalleGalponId=@DetalleGalponId";
                conn.Execute(deleteQuery, new { DetalleGalponId = detalleGalponId });
            }
        }

        public void Editar(Detalle_Galpon detalleGalpon)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery;
                if (detalleGalpon.FechaEgreso==null)
                {
                    updateQuery = @"UPDATE Detalle_Galpon SET 
                                   FechaIngreso=@FechaIngreso,
                                   TotalIngreso=@TotalIngreso 
                                   WHERE DetalleGalponId=@DetalleGalponId";
                }
                else
                {
                    updateQuery = @"UPDATE Detalle_Galpon SET 
                                   FechaIngreso=@FechaIngreso,
                                   TotalIngreso=@TotalIngreso,
                                   FechaEgreso=@FechaEgreso
                                   WHERE DetalleGalponId=@DetalleGalponId";
                }
                
                conn.Execute(updateQuery, detalleGalpon);
            }
        }

        public bool ExisteDetalleGalponSinFechaEgreso(int galponId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"SELECT COUNT(*) 
                             FROM Detalle_Galpon 
                             WHERE GalponId = @GalponId AND FechaEgreso IS NULL";
                return conn.ExecuteScalar<int>(query, new { GalponId = galponId }) > 0;
            }
        }

        public Detalle_Galpon GetDetalleGalponesPorId(int detalleGalponId)
        {
            Detalle_Galpon detalleGalpon = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT DetalleGalponId, GalponId, FechaHoy, FechaIngreso, FechaEgreso, TotalIngreso
                               FROM Detalle_Galpon
                               WHERE DetalleGalponId = @DetalleGalponId";
                detalleGalpon = conn.QuerySingleOrDefault<Detalle_Galpon>(selectQuery, new { DetalleGalponId = detalleGalponId });
            }
            return detalleGalpon;
        }
    }
}
