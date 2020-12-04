using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Asistencia
    {

        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;

        public string FechaReferencia { get => _fechaReferencia; set => _fechaReferencia = value; }

        public Asistencia (string fecha, Alumno alumno, Preceptor preceptor, bool presente)
        {
            this._fechaReferencia = fecha;
            this._fechaHoraReal = DateTime.Now;
            this._alumno = alumno;
            this._preceptor = preceptor;
            this._estaPresente = presente;

        }

        public override string ToString()
        {
            return $"Alumno: {this._alumno.ToString()}| Fecha: {_fechaReferencia} Presente: {_estaPresente}";
        }
    }
}
