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
    public class CategoriaMapper
    {
        public TransactionResult Insert(Categoria categoriaNuevo)
        {
            NameValueCollection obj = ReverseMap(categoriaNuevo);
            string ResultadoPost = WebHelper.Post("/api/v1/estudiocontable/Categoria", obj);
            TransactionResult result = MapResultado(ResultadoPost);
            return result;
        }

        private NameValueCollection ReverseMap(Categoria categoria)
        {
            NameValueCollection n = new NameValueCollection();
         
            n.Add("Nombre", categoria.Nombre);
            n.Add("SueldoBasico", categoria.SueldoBasico.ToString());
            n.Add("Convenio", categoria.Convenio);
            return n;
        }

        private TransactionResult MapResultado(string resultado)
        {
            TransactionResult resultadoDeserializado = JsonConvert.DeserializeObject<TransactionResult>(resultado);
            return resultadoDeserializado;
        }

        public List<Categoria> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/estudiocontable/categorias");
            List<Categoria> resultadomapeo = MapList(json);
            return resultadomapeo;

        }
        private List<Categoria> MapList(string jsonADeserializar)
        {
            List<Categoria> lstDeserializada = JsonConvert.DeserializeObject<List<Categoria>>(jsonADeserializar);
            return lstDeserializada;
        }
    }
}

