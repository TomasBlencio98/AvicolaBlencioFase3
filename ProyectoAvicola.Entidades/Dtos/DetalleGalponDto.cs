using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class DetalleGalponDto
    {
        public int DetalleGalponId { get; set; }
        public int GalponId { get; set; }
        public string? NombreGalpon { get; set; }
        public int Capacidad { get; set; } 
        public string? NombreGranja { get; set; }
        public int GranjaId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public int TotalIngreso { get; set; }
    }
}
