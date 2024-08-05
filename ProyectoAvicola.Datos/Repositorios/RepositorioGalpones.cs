using Dapper;
using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Entidades.Dtos;
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
    public class RepositorioGalpones : IRepositorioGalpones
    {
        private readonly string cadenaConexion;
        public RepositorioGalpones()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Galpon galpon)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"insert into Galpon 
                (GranjaId, Capacidad, NombreGalpon) values (@GranjaId, @Capacidad, @NombreGalpon); 
                SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, galpon);
                galpon.GalponId = id;
            }
        }

        public void Borrar(int GalponId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Galpon WHERE GalponId=@GalponId";
                conn.Execute(deleteQuery, new { GalponId });
            }
        }

        public void Editar(Galpon galpon)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"update Galpon set 
                GranjaId=@GranjaId, Capacidad=@Capacidad, NombreGalpon=@NombreGalpon 
                where GalponId=@GalponId";
                conn.Execute(updateQuery, galpon);
            }
        }

        public bool Existe(Galpon galpon)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (galpon.GalponId == 0)
                {
                    selectQuery = @"select count(*) from Galpon 
                    where GranjaId=@GranjaId and Capacidad=@Capacidad and NombreGalpon=@NombreGalpon";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, galpon);
                }
                else
                {
                    selectQuery = @"select count(*) from Galpon 
                    where GranjaId=@GranjaId and Capacidad=@Capacidad and NombreGalpon=@NombreGalpon and GalponId!=@GalponId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, galpon);
                }
            }
            return cantidad > 0;
        }

        public List<DetalleGalponDto> GetDetalleGalpon(int galponId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"SELECT dg.DetalleGalponId, ga.GalponId, 
                         ga.NombreGalpon, ga.Capacidad, gr.NombreGranja, gr.GranjaId, 
                            dg.FechaIngreso, dg.FechaEgreso, dg.TotalIngreso
                         FROM Detalle_Galpon dg
                         INNER JOIN Galpon ga ON dg.GalponId = ga.GalponId
                         INNER JOIN Granja gr ON ga.GranjaId = gr.GranjaId
                         WHERE ga.GalponId = @GalponId";
                return conn.Query<DetalleGalponDto>(query, new { GalponId = galponId }).ToList();
            }
        }
        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Galpon";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }

        public int GetCantidadGalponesPorGranja(int granjaId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT COUNT(*) AS NumeroDeGalpones FROM Galpon WHERE GranjaId = @GranjaId";
                int numeroDeGalpones = conn.ExecuteScalar<int>(query, new { GranjaId = granjaId });
                return numeroDeGalpones;
            }
        }

        public List<GalponDto> GetGalpones()
        {
            List<GalponDto> lista = new List<GalponDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = 
                    @"SELECT ga.GalponId, gr.NombreGranja, 
                     ga.Capacidad, ga.NombreGalpon 
                     FROM Galpon ga 
                     INNER JOIN Granja gr ON ga.GranjaId = gr.GranjaId
                     ORDER BY gr.NombreGranja, ga.NombreGalpon";
                lista = conn.Query<GalponDto>(selectQuery).ToList();
            }
            return lista;
        }

        public Galpon GetGalponesPorId(int GalponId)
        {
            Galpon galpon = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"select GalponId, GranjaId, 
                Capacidad, NombreGalpon from Galpon where GalponId=@GalponId";
                galpon = conn.QuerySingleOrDefault<Galpon>(selectQuery, new { GalponId });
            }
            return galpon;
        }

        public List<GalponDto> GetGalponesPorGranjaId(int granjaId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"SELECT ga.GalponId, ga.GranjaId, ga.NombreGalpon, ga.Capacidad, gr.NombreGranja
                         FROM Galpon ga
                         INNER JOIN Granja gr ON ga.GranjaId = gr.GranjaId
                         WHERE ga.GranjaId = @GranjaId
                         ORDER BY ga.NombreGalpon";
                return conn.Query<GalponDto>(query, new { GranjaId = granjaId }).ToList();
            }
        }
    }
}
