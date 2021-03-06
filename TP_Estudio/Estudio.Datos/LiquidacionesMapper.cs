﻿using Estudio.Entidades;
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
   public class LiquidacionesMapper
    {
        public TransactionResult Insert(Liquidaciones liquidacionNuevo)
        {
            NameValueCollection obj = ReverseMap(liquidacionNuevo);
            string ResultadoPost = WebHelper.Post("/api/v1/estudiocontable/Liquidacion", obj);
            TransactionResult result = MapResultado(ResultadoPost);
            return result;
        }

        private NameValueCollection ReverseMap(Liquidaciones liquidaciones)
        {
            NameValueCollection n = new NameValueCollection();
          
            n.Add("IdEmpleado", liquidaciones.IdEmpleado.ToString());
            n.Add("CodigoTransferencia", liquidaciones.CodigoTransferencia.ToString());
            n.Add("Periodo", liquidaciones.Periodo.ToString());
            n.Add("Bruto", liquidaciones.Bruto.ToString());
            n.Add("Descuentos", liquidaciones.Descuentos.ToString());
            n.Add("FechaAlta", "19/11/2020");
            return n;
        }

        private TransactionResult MapResultado(string resultado)
        {
            TransactionResult resultadoDeserializado = JsonConvert.DeserializeObject<TransactionResult>(resultado);
            return resultadoDeserializado;
        }

        public List<Liquidaciones> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/estudiocontable/liquidaciones/"); //+ ConfigurationManager.AppSettings["Legajo"]);
            List<Liquidaciones> resultadomapeo = MapList(json);
            return resultadomapeo;

        }
        private List<Liquidaciones> MapList(string jsonADeserializar)
        {
            List<Liquidaciones> lstDeserializada = JsonConvert.DeserializeObject<List<Liquidaciones>>(jsonADeserializar);
            return lstDeserializada;
        }
    }
}

