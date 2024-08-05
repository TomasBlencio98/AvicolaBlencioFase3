using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class MedicamentoDto
    {
        public int MedicamentoId { get; set; }
        public string TipoMedicamento { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
