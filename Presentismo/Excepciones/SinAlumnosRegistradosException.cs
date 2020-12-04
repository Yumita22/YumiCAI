using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinAlumnosRegistradosException:Exception
    {
        public override string Message => "No hay alumnos registrados en el curso";


    }
}
