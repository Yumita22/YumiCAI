using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AsistenciaExistenteEseDiaException:Exception
    {
        public override string Message => "Asistencia ya cargada";

    }
}
