using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Preceptor:Persona
    {
        private int _legajo;

        public int Legajo { get => _legajo; set => _legajo = value; }

        public Preceptor(int legajo, string nombre, string apellido):base(nombre, apellido)
        {
            this._legajo = Legajo;
        }

        internal override string Display()
        {
            return $"Apellido: { Apellido} | Nombre: {Nombre} |  Legajo : { Legajo}"+ToString();
        }
    }
}
