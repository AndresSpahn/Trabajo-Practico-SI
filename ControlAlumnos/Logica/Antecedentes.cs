using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Antecedentes
    {
        public int CodigoUniversidad { get; set; }
        public string TipoUniversidad { get; set; }
        public TiposDNI TipoDNI { get; set; }
        public int NumeroDNI { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
    }
}