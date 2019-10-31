using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public enum TiposDNI
    {
        DNI,
        DNI_Extranjeo
    }

    public class Alumnos
    {
        public TiposDNI TipoDNI { get; set; }
        public int NumeroDNI { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public int CodigoNacionalidad { get; set; }
    }
}