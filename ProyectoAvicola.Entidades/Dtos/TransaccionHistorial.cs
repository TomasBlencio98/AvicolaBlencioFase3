using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class TransaccionHistorial
    {
        public int transaccionId { get; set; }
        public DateTime fecha { get; set; }
        public string nombreProveedor { get; set; }
    }
}
