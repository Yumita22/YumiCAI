﻿using Estudio.Datos;
using Estudio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocios
{
    public class CategoriaServicio
    {

        private CategoriaMapper mapper;
        public CategoriaServicio()
        {
            mapper = new CategoriaMapper();
        }
        public List<Categoria> GetCategorias()
        {
            List<Categoria> result = mapper.TraerTodos();
            return result;
        }

        public List<Categoria> GetCategoriasPorConvenio(string convenio)
        {
            List<Categoria> categorias = new List<Categoria>();
            foreach (Categoria c in this.GetCategorias())
            {
                if (c.Convenio == convenio)
                {
                    categorias.Add(c);
                }
            }
            return categorias;
        }

        public int InsertarCategoria( string nombre, string convenio, double sueldoBasico)
        {
            Categoria categoria = new Categoria(nombre,convenio,sueldoBasico);
            //categoria.Id = id;
            categoria.Nombre = nombre;
            categoria.Convenio = convenio;
            categoria.SueldoBasico = sueldoBasico;
            TransactionResult resultante = mapper.Insert(categoria);

            if (resultante.IsOk)
            {
                return resultante.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
            }
        }
        internal bool Existe(int idCategoria)
        {
            List<Categoria> lst = GetCategorias();
            foreach (Categoria c in lst)
            {
                if (idCategoria == c.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

