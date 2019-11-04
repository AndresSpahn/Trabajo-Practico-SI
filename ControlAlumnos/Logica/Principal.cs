using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        private string path = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "")}";

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
        
        //Metodo Universidades Estatales
        public ResultadoEstatal CantidadEsudiantesUniversidadProvincia()
        {
            ResultadoEstatal Resultado = new ResultadoEstatal();

            foreach (var Provincia in ListaProvincias)
            {
                Resultado.ListaProvincias.Add(Provincia.Nombre);

                foreach (var sede in ListaSedes)
                {
                    if (sede.CodigoProvincia == Provincia.CodigoProvincia && sede.TipoUniversidad == "Estatal")
                    {
                        EstudiantesxUniversidad Cantidad = new EstudiantesxUniversidad();
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
                                        Becados aux = new Becados();

                                        foreach (var Alumno in ListaAlumnos)
                                        {
                                            if (Beca.NumeroDNI == Alumno.NumeroDNI && Beca.TipoDNI == Alumno.TipoDNI)
                                            {
                                                 aux.NombreEstudiante = Alumno.NombreCompleto;
                                                 aux.SedeUniversidad = Universidad.Nombre;
                                                 Resultado.ListaBecados.Add(aux);
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
                        Resultado.ListaEstudiantesUniversidad.Add(Cantidad);
                    }
                }
            }
            return Resultado;
        }

        //Metodo Universidades Privadas
        public ResultadoPrivadas CantidadEsudiantesUniversidadSede()
        {
            ResultadoPrivadas Resultado = new ResultadoPrivadas();

            foreach (var Universidad in ListaUniversidades)
            {
                if (Universidad.TipoUniversidad == "Privada")
                {
                    Resultado.ListaUniversidades.Add(Universidad.Nombre);

                    foreach (var Sede in ListaSedes)
                    {
                        if (Sede.CodigoUniversidad == Universidad.CodigoUniversidad && Sede.TipoUniversidad == Universidad.TipoUniversidad)
                        {
                            EstudiantesxSedes Cantidad = new EstudiantesxSedes();
                            Cantidad.NombreSede = Sede.NombreSede;
                            Cantidad.NombreUniversidad = Universidad.Nombre;

                            foreach (var Estudiante in ListaAlumnoUniversidad)
                            {
                                if (Estudiante.CodigoUniversidad == Universidad.CodigoUniversidad && Estudiante.TipoUniversidad == Universidad.TipoUniversidad && Estudiante.CodigoProvincia == Sede.CodigoProvincia)
                                {
                                    Cantidad.CantidadEstudiantes += 1;

                                    foreach (var Beca in ListaBecas)
                                    {
                                        if (Beca.TipoDNI == Estudiante.TipoDNI && Beca.NumeroDNI == Estudiante.NumeroDNI && Beca.CodigoProvincia == Estudiante.CodigoProvincia)
                                        {
                                            Becados bec = new Becados();
                                            bec.SedeUniversidad = Sede.NombreSede;

                                            foreach (var Alumno in ListaAlumnos)
                                            {
                                                if (Estudiante.TipoDNI == Alumno.TipoDNI && Estudiante.NumeroDNI == Alumno.NumeroDNI)
                                                {
                                                    bec.NombreEstudiante = Alumno.NombreCompleto;
                                                }
                                            }
                                            Resultado.ListaBecados.Add(bec);
                                        }
                                    }
                                }
                            }
                            Resultado.ListaEstudiantesSedes.Add(Cantidad);
                        }
                    }
                }
            }
            return Resultado;
        }
    }
}