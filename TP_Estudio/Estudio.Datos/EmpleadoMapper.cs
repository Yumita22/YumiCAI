using Estudio.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Datos
{
    public class EmpleadoMapper
    {
        public TransactionResult Insert(Empleado empleadoNuevo)
        {
            NameValueCollection obj = ReverseMap(empleadoNuevo);
            string ResultadoPost = WebHelper.Post("/api/v1/estudiocontable/Empleado", obj);
            TransactionResult result = MapResultado(ResultadoPost);
            return result;
        }

        private NameValueCollection ReverseMap(Empleado empleado)
        {
            NameValueCollection n = new NameValueCollection();
            
            n.Add("idCategoria", empleado.idCategoria.ToString());
            n.Add("idEmpresa", empleado.idEmpresa.ToString());
            n.Add("Cuil", empleado.cuil.ToString());
            n.Add("Nombre", empleado.Nombre);
            n.Add("Apellido", empleado.Apellido);        
            n.Add("FechaNacimiento", empleado.fechaNacimiento.ToString());
            n.Add("FechaAlta","19/11/2020");
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return n;
        }

        private TransactionResult MapResultado(string resultado)
        {
            TransactionResult resultadoDeserializado = JsonConvert.DeserializeObject<TransactionResult>(resultado);
            return resultadoDeserializado;
        }

        public List<Empleado> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/estudiocontable/empleados/");
               
            List<Empleado>resultadomapeo = MapList(json);
            return resultadomapeo;

        }
        private List<Empleado> MapList (string jsonADeserializar)
        {
            List<Empleado> lstDeserializada = JsonConvert.DeserializeObject<List<Empleado>>(jsonADeserializar);
            return lstDeserializada;
        }
    }
}
