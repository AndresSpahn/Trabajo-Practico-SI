using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VariacionMatricula
    {
        public int CodigoUniversidad { get; set; }
        public PrivadaEstatal TipoUniversidad { get; set; }
        public double ValorActual { get; set; }
        public double ValorAnterior { get; set; }
        public DateTime FechaVariacion { get; set; }
    }
}