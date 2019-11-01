using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ResultadoEstatal
    {
        public List<string> ListaProvincias { get; set; }
        public List<EstudiantesxUniversidad> ListaEstudiantesUniversidad { get; set; }
        public List<Becados> ListaBecados { get; set; }
    }
}