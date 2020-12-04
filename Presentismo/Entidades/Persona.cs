using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;

        public Persona (string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;

        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public override string ToString()
        {
            return ("Nombre: "+ Nombre+" | Apellido "+ Apellido);
        }

        internal abstract string Display();

    }
}
