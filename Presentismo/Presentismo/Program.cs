using Entidades;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjAsistencia
{
    public class Program
    {
        private static Presentismo _presentismo;

        static Program()
        {
            _presentismo = new Presentismo();
        }
        static void Main(string[] args)
        {
            Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();

            DesplegarOpcionesMenu();
            string opcionMenu = ""; // pedir el valor
            opcionMenu = Console.ReadLine();
            do
            {
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        // SALIR
                        break;
                    default:
                        break;
                }
            } while (opcionMenu != "X");

        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {
            // Ingreso fecha
            
            List<Asistencia> asistencias = new List<Asistencia>();
            Console.WriteLine("Ingrese una fecha");
            string fecha = Console.ReadLine();

            // Listar los alumnos
            try
            {
                Console.WriteLine(_presentismo.GetListaAlumnos(_presentismo.Alumnos));
            }
            catch (SinAlumnosRegistradosException ex)
            {
                Console.WriteLine( (ex.Message));
            }
            // para cada alumno solo preguntar si está presente

            foreach (Alumno a in _presentismo.Alumnos)
            {
                if (a is AlumnoRegular)
                {
                    bool presente = false;
                    Console.WriteLine(a.ToString());
                    Console.WriteLine("¿está presente? (S/N)");
                    string asistencia = Console.ReadLine();
                    if (asistencia.Equals("S"))
                    {
                        presente = true;
                    }
                    asistencias.Add(new Asistencia(fecha, a, p, presente));
                }
            }
            // agrego la lista de asistencia
            // Error: mostrar el error y que luego muestre el menu nuevamente
            try
            {
                _presentismo.AgregarAsistencia(asistencias, fecha);
            }
            catch (AsistenciaExistenteEseDiaException ex)
            {
                Console.WriteLine(ex.Message);
                DesplegarOpcionesMenu();
            }
        }
        static void MostrarAsistencia()
        {
            string listaAsistencia = "";
            List<Asistencia>_asistencias;
            Console.WriteLine("Ingrese una fecha");
            string fecha = Console.ReadLine();

            _asistencias = _presentismo.GetAsistenciaPorFecha(fecha);
            if (_asistencias.Count == 0){ Console.WriteLine("No hay asistencias para la fecha"); DesplegarOpcionesMenu(); }
            else
                foreach(Asistencia a in _asistencias)
                {
                    listaAsistencia += a.ToString();
                }
            Console.WriteLine(listaAsistencia);
            

            // ingreso fecha


            // muestro el toString de cada asistencia
        }
    }

}
