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
    public class RepositorioDetalleGalpon_Alimentos : IRepositorioDetalleGalpon_Alimentos
    {
        private readonly string cadenaConexion;
        public RepositorioDetalleGalpon_Alimentos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void AgregarDetalleGalponAlimento
            (DetalleGalpon_Alimento detalleGalponAlimento)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO DetalleGalpon_Alimento 
                                   (DetalleGalponId, AlimentoId, Cantidad, Fecha) 
                                   VALUES (@DetalleGalponId, @AlimentoId, @Cantidad, @Fecha); 
                                   SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, detalleGalponAlimento);
                detalleGalponAlimento.DetalleGalponAlimentosId = id;
            }
        }
    }
}
