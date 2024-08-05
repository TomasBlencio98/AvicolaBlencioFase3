using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Datos.Repositorios;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Servicios
{
    public class ServicioDetalleGalpon_Alimentos : IServicioDetalleGalpon_Alimentos
    {
        private readonly IRepositorioDetalleGalpon_Alimentos repositorioDetalleGalpon_Alimentos;
        public ServicioDetalleGalpon_Alimentos()
        {
            repositorioDetalleGalpon_Alimentos = new RepositorioDetalleGalpon_Alimentos();
        }
        public void AgregarDetalleGalponAlimento
            (DetalleGalpon_Alimento detalleGalponAlimento)
        {
            try
            {
                repositorioDetalleGalpon_Alimentos
                    .AgregarDetalleGalponAlimento(detalleGalponAlimento);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
