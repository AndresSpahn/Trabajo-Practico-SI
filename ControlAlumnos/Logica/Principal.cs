using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        List<Alumnos> ListaAlumnos = new List<Alumnos>();
        List<Universidades> ListaUniversidades = new List<Universidades>();
        List<Becas> ListaBecas = new List<Becas>();
        List<Antecedentes> ListaAntecedentes = new List<Antecedentes>();
        List<Sedes> ListaSedes = new List<Sedes>();
        List<VariacionMatricula> ListaMatriculas = new List<VariacionMatricula>();
        List<Provincias> ListaProvincias = new List<Provincias>();
        List<Localidades> ListaLocalidades = new List<Localidades>();
        List<Nacionalidades> ListaNacionaliades = new List<Nacionalidades>();
        List<AlumnoUniversidadSede> ListaAlumnoUniversidad = new List<AlumnoUniversidadSede>();

        public ResultadoEstatal CantidadEsudiantesUniversidadProvincia()
        {
            ResultadoEstatal Resultado = new ResultadoEstatal();

            foreach (var Provincia in ListaProvincias)
            {
                Resultado.ListaProvincias.Add(Provincia.Nombre);
                EstudiantesxUniversidad Cantidad = new EstudiantesxUniversidad();

                bool ban = false;
                foreach (var sede in ListaSedes)
                {
                    if (sede.CodigoProvincia == Provincia.CodigoProvincia && sede.TipoUniversidad == "Estatal")
                    {
                        if (ban == false)
                        {
                            ban = true;
                            Cantidad.NombreProvincia = Provincia.Nombre;
                            foreach (var Universidad in ListaUniversidades)
                            {
                                if (Universidad.CodigoUniversidad == Universidad.CodigoUniversidad && Universidad.TipoUniversidad == Universidad.TipoUniversidad)
                                {
                                    Cantidad.NombreUniversidad = Universidad.Nombre;

                                    foreach (var Beca in ListaBecas)
                                    {
                                        if (Beca.CodigoUniversidad == Universidad.CodigoUniversidad && Universidad.TipoUniversidad == Beca.TipoUniversidad && Beca.CodigoProvincia == Provincia.CodigoProvincia)
                                        {
                                            foreach (var Alumno in ListaAlumnos)
                                            {
                                                if (Beca.NumeroDNI == Alumno.NumeroDNI && Beca.TipoDNI == Alumno.TipoDNI)
                                                {
                                                    Becados aux = new Becados();
                                                    aux.NombreEstudiante = Alumno.NombreCompleto;
                                                    aux.SedeUniversidad = Universidad.Nombre;
                                                    Resultado.ListaBecados.Add(aux);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        foreach (var Estudiante in ListaAlumnoUniversidad)
                        {
                            if (Estudiante.CodigoUniversidad == sede.CodigoUniversidad && sede.TipoUniversidad == Estudiante.TipoUniversidad && Estudiante.CodigoProvincia == Provincia.CodigoProvincia)
                            {
                                Cantidad.CantidadEstudiantes += 1;
                            }
                        }
                    }
                }
                Resultado.ListaEstudiantesUniversidad.Add(Cantidad);
            }

            return Resultado;
        }

        public ResultadoPrivadas CantidadEsudiantesUniversidadSede()
        {
            ResultadoPrivadas Resultado = new ResultadoPrivadas();


            return Resultado;
        }
    }
}