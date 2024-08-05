using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class TransaccionDto
    {
        public int itemId { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}
