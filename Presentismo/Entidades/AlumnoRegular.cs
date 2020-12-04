using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoRegular:Alumno
    {
        private string _email;

        public string Email { get => _email; set => _email = value; }

        public AlumnoRegular(int registro, string nombre, string apellido,  string email):base(registro, nombre, apellido)
        {
            this._email = email;
        }
    }
}
