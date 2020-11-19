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
    public class EmpresaMapper
    {
        public TransactionResult Insert(Empresa empresaNuevo)
        {
            NameValueCollection obj = ReverseMap(empresaNuevo);
            string ResultadoPost = WebHelper.Post("/api/v1/estudiocontable/empresa/", obj);
            TransactionResult result = MapResultado(ResultadoPost);
            return result;
        }

        private NameValueCollection ReverseMap(Empresa empresa)
        {
            NameValueCollection n = new NameValueCollection();
           // n.Add("IdEmpresa", empresa.Id.ToString());
            n.Add("RazonSocial", empresa.RazonSocial);
            n.Add("Cuil", empresa.Cuil.ToString());
            n.Add("Domicilio", empresa.Domicilio);
            n.Add("FechaAlta", "19/11/2020");
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return n;
        }

        private TransactionResult MapResultado(string resultado)
        {
            TransactionResult resultadoDeserializado = JsonConvert.DeserializeObject<TransactionResult>(resultado);
            return resultadoDeserializado;
        }

        public List<Empresa> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/estudiocontable/empresas/");
            //+ ConfigurationManager.AppSettings["Legajo"]);
            List<Empresa> resultadomapeo = MapList(json);
            return resultadomapeo;

        }
        private List<Empresa> MapList(string jsonADeserializar)
        {
            List<Empresa> lstDeserializada = JsonConvert.DeserializeObject<List<Empresa>>(jsonADeserializar);
            return lstDeserializada;
        }
    }
}

