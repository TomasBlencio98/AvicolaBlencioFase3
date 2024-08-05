using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class AlimentoDto
    {
        public int AlimentoId { get; set; }
        public string TipoAlimento { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
