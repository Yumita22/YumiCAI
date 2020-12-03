using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class VentaRepuesto
    {
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        public VentaRepuesto (string nombreComercio, string direccion)
        {
            this._nombreComercio = nombreComercio;
            this._direccion = direccion;
            this._listaProductos = new List<Repuesto>();

        }

        public List<Repuesto> ListaProductos { get => _listaProductos; set => _listaProductos = value; }
        public string NombreComercio { get => _nombreComercio; set => _nombreComercio = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public void AgregarRepuesto(Repuesto repuesto)
        {
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Codigo==repuesto.Codigo)
                {
                    throw new Exception("El repuesto ya fue ingresado");
                }
                else
                {
                    _listaProductos.Add(repuesto);
                }
            }

        }

        public void QuitarRepuesto(int codigo)
        {
            Repuesto sacar = null;
            foreach (Repuesto quitar in this._listaProductos)
            {
                if (quitar.Codigo==codigo)
                {
                    sacar = quitar;
                    _listaProductos.Remove(quitar);
                    sacar = null;
                    break;
                }
                else
                {
                    throw new Exception("el repuesto no existe");
                }
            }

        }
        public void ModificarPrecio(int codigo, double precioModidicado)
        {
            bool stock = false;
            foreach(Repuesto modificar in _listaProductos)
            {
                if(modificar.Codigo==codigo)
                {
                    modificar.Precio = precioModidicado;
                    stock = true;
                }
            }
            if (!stock)
            {
                throw new Exception("el repuesto no existe");
            }
        }
        public void AgregarStock(int codigo, int cantidad)
        {
            foreach (Repuesto agregar in this._listaProductos)
            {
                if(agregar.Codigo==codigo)
                {
                    agregar.Stock = agregar.Stock + cantidad;
                }
            }

        }
        public void QuitarStock(int codigo, int cantidad)
        {

            foreach (Repuesto quitar in this._listaProductos)
            {
                if (quitar.Codigo == codigo)
                {
                    if (quitar.Stock > cantidad)
                    {
                        quitar.Stock = quitar.Stock - cantidad;
                    }
                    else
                    {
                        throw new Exception("La cantidad ingresada supera el stock existente");
                    }
                }
            }
        }
        public List<Repuesto> TraerPorCategoria(int codigoCategoria)
        {
            List<Repuesto> lista = new List<Repuesto>();
            foreach( Repuesto r in _listaProductos)
            {
                if(r.Categoria.Codigo==codigoCategoria)
                {
                    lista.Add(r);
                }
            }
            if (lista.Count!=0)
            {
                return lista;
            }
            else
            {
                throw new Exception("No hay ítems en esta categoría.");
            }
                

            
        }
    }
}
