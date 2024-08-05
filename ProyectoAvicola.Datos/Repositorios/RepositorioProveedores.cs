using Dapper;
using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Repositorios
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
        private readonly string cadenaConexion;
        public RepositorioProveedores()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Proveedor proveedor)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Proveedor 
                    (LocalidadId, NombreProveedor, 
                    ApellidoProveedor, Telefono, Email)
                    VALUES(@LocalidadId, @NombreProveedor, @ApellidoProveedor, @Telefono, @Email); 
                    SELECT SCOPE_IDENTITY()";
                int id = conn.ExecuteScalar<int>(insertQuery, proveedor);
                proveedor.ProveedorId= id;
            }
        }

        public void AsignarGranjaAProveedor(int proveedorId, int granjaId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"
                INSERT INTO Granja_Proveedor (ProveedorId, GranjaId)
                VALUES (@ProveedorId, @GranjaId)";

                conn.Execute(query, new { ProveedorId = proveedorId, GranjaId = granjaId });
            }
        }

        public void Borrar(int ProveedorId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Proveedor WHERE ProveedorId=@ProveedorId";
                conn.Execute(deleteQuery, new { ProveedorId });
            }
        }

        public void Editar(Proveedor proveedor)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Proveedor SET 
                LocalidadId=@LocalidadId, NombreProveedor=@NombreProveedor, 
                ApellidoProveedor=@ApellidoProveedor, Telefono=@Telefono, 
                Email=@Email WHERE ProveedorId=@ProveedorId";
                conn.Execute(updateQuery, proveedor);
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (proveedor.LocalidadId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Proveedor 
                    WHERE NombreProveedor=@NombreProveedor AND ApellidoProveedor=@ApellidoProveedor 
                    AND Telefono=@Telefono AND Email=@Email AND LocalidadId=@LocalidadId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, proveedor);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Proveedor WHERE
                    NombreProveedor=@NombreProveedor AND ApellidoProveedor=@ApellidoProveedor 
                    AND Telefono=@Telefono AND Email=@Email AND LocalidadId=@LocalidadId AND
                    ProveedorId!=@ProveedorId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, proveedor);
                }
            }
            return cantidad > 0;
        }

        public bool ExisteRelacion(int proveedorId, int granjaId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"
                SELECT COUNT(*)
                FROM Granja_Proveedor
                WHERE ProveedorId = @ProveedorId AND GranjaId = @GranjaId";

                return conn.ExecuteScalar<int>(query, new { ProveedorId = proveedorId, GranjaId = granjaId }) > 0;
            }
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Proveedor";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }

        public int GetCantidadGranjasPorProveedor(int proveedorId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"SELECT COUNT(*)
                FROM Granja_Proveedor
                WHERE ProveedorId = @ProveedorId";
                return conn.ExecuteScalar<int>(query, new { ProveedorId = proveedorId });
            }
        }

        public int GetCantidadProveedoresPorGranja(int granjaId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT COUNT(*) AS NumeroDeProveedores FROM Granja_Proveedor WHERE GranjaId = @GranjaId";
                int numeroDeProveedores = conn.ExecuteScalar<int>(query, new { GranjaId = granjaId });
                return numeroDeProveedores;
            }
        }

        public List<Granja> GetGranjasPorProveedor(int proveedorId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"
                SELECT g.GranjaId, g.NombreGranja
                FROM Granja g
                JOIN Granja_Proveedor gp ON g.GranjaId = gp.GranjaId
                WHERE gp.ProveedorId = @ProveedorId";

                return conn.Query<Granja>(query, new { ProveedorId = proveedorId }).ToList();
            }
        }

        public List<ProveedorDto> GetProveedores()
        {
            List<ProveedorDto> lista = new List<ProveedorDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT P.ProveedorId,L.NombreLocalidad,
                P.NombreProveedor, P.ApellidoProveedor, P.Telefono 
                FROM Proveedor P INNER JOIN Localidad L 
                on L.LocalidadId = P.LocalidadId";
                lista = conn.Query<ProveedorDto>(selectQuery).ToList();
            }
            return lista;
        }

        public Proveedor GetProveedorPorId(int proveedorId)
        {
            Proveedor proveedor = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT ProveedorId, LocalidadId,
                NombreProveedor, ApellidoProveedor, Telefono, Email  
                FROM Proveedor WHERE ProveedorId=@ProveedorId";
                proveedor = conn.QuerySingleOrDefault<Proveedor>(selectQuery, new { proveedorId });
            }
            return proveedor;
        }

        public void QuitarGranjaDeProveedor(int proveedorId, int granjaId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string query = @"
                DELETE FROM Granja_Proveedor
                WHERE ProveedorId = @ProveedorId AND GranjaId = @GranjaId";
                conn.Execute(query, new { ProveedorId = proveedorId, GranjaId = granjaId });
            }
        }
    }
}
