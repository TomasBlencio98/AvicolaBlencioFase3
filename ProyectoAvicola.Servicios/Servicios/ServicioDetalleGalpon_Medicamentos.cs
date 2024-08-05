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
    public class ServicioDetalleGalpon_Medicamentos 
        : IServicioDetalleGalpon_Medicamentos
    {
        private readonly IRepositorioDetalleGalpon_Medicamentos
            repositorioDetalleGalpon_Medicamentos;
        public ServicioDetalleGalpon_Medicamentos()
        {
            repositorioDetalleGalpon_Medicamentos = 
                new RepositorioDetalleGalpon_Medicamentos();
        }
        public void AgregarDetalleGalponMedicamento
            (DetalleGalpon_Medicamento d)
        {
            try
            {
                repositorioDetalleGalpon_Medicamentos
                    .AgregarDetalleGalponMedicamento(d);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
