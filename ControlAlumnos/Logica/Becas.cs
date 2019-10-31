using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Becas
    {
        public int CodigoBeca { get; set; }
        public int CodigoUniversidad { get; set; }
        public string TipoUniversidad { get; set; }
        public string Nombre { get; set; }
        public TiposDNI TipoDNI { get; set; }
        public int NumeroDNI { get; set; }
        public int AñoObtenido { get; set; }
        public int CodigoProvincia { get; set; }
    }
}