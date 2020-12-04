using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Presentismo
    {
        private List<Preceptor> _preceptores;
        private List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;
        private List<string> _fechas;

        public List <Preceptor> Preceptores { get { return _preceptores; } }
        public List<Alumno> Alumnos { get { return _alumnos; } }
        public List<Asistencia> Asistencia { get { return _asistencias; } }
        public List<string> Fechas { get { return _fechas; } }

        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();
            _fechas = new List<string>();

            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));

            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));

        }

       

        public List<Asistencia> GetAsistenciaPorFecha(string fecha)
        {
            List<Asistencia> asis = new List<Asistencia>();
            foreach(Asistencia a in _asistencias)
            {
                if (a.FechaReferencia.Equals(fecha))
                {
                    asis.Add(a);
                }

            }
            return asis;

        }
        public bool AsistenciaRegistrada(string fecha)
        {
            List<Asistencia> asistencia = GetAsistenciaPorFecha(fecha);
            foreach (Asistencia a in asistencia)
            {
                if (a.FechaReferencia.Equals(fecha))
                {
                    return true;
                }

            }
            return false;
        }

        public int GetCantidadAlumnosRegulares()
        {
                     
            List<AlumnoRegular> alumnos = new List<AlumnoRegular>();
            return alumnos.Count;
                     

        }
        public Preceptor GetPreceptorActivo()
        {
            Preceptor preceptorActivo = _preceptores[0];
            return preceptorActivo;
        }

        public string GetListaAlumnos(List<Alumno>alumnos)
        {
            string listaAlumnos = "";
            foreach (Alumno alumno in alumnos) 
            {
                if (alumno is AlumnoOyente)
                {
                    listaAlumnos += alumno.ToString() + " es oyente\n";
                }
                else
                {
                    listaAlumnos += alumno.ToString() + " es regular\n";
                }
            }
            if (listaAlumnos == "")  throw new SinAlumnosRegistradosException(); 

            return listaAlumnos;
        }
        public  void AgregarAsistencia(List<Asistencia> asistencias, string fecha)
        {
            List<Alumno> alumnos = new List<Alumno>();
            foreach (Alumno a in alumnos)
            {
                if (a is AlumnoRegular)
                {
                    alumnos.Add(a);
                }
            }
            foreach (string f in _fechas)
            {
                if (Fechas.Equals(fecha))
                {
                    throw new AsistenciaExistenteEseDiaException();
                }
            }

            foreach (Asistencia asistencia in asistencias)
            {
                asistencias.Add(asistencia);
            }
            this.Fechas.Add(fecha);


        }
    }
}
