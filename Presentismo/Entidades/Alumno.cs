using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno:Persona
    {
        private int _registro;

        public Alumno(int registro, string nombre, string apellido):base(nombre,apellido)
        {
            this._registro = registro;
        }
        public int Registro { get => _registro; set => _registro = value; }

        internal override string Display()
        {
            return base.ToString() + $"Registro: {Registro}";
        }
          
    }
}
