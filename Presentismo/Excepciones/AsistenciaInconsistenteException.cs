using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AsistenciaInconsistenteException:Exception
    {
        public override string Message => "Asistencia Inconsistente";
    }
}
