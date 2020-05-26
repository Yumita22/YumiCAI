
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Expendedora_v1;

namespace Datos.Expendedora
{
    public class Maqexp
    {
        private List<Lata> _latas = new List<Lata>();
        private bool encendida;
        private double dinero;
        private int capacidad;
        private string proveedor;

        public Maqexp(int Capacidad, string Proveedor)
        {
            this.capacidad = Capacidad;
            this.proveedor = Proveedor;
            _latas.Add(new Lata("CO1", "Coca Cola Regular", 50.00, 0.5, "Regular"));
            _latas.Add(new Lata("CO2", "Coca Cola Zero", 50.00, 0.5, "Sin Azúcar"));
            _latas.Add(new Lata("SP1", "Sprite Regular", 50.00, 0.5, "Regular"));
            _latas.Add(new Lata("SP2", "Sprite Zero", 50.00, 0.5, "Sin Azúcar"));
            _latas.Add(new Lata("FA1", "Fanta Regular", 50.00, 0.5, "Regular"));
            _latas.Add(new Lata("FA2", "Fanta Zero", 50.00, 0.5, "Sin Azúcar"));
        }

        public List<Lata> Latas { get { return this._latas; } }
        public bool Encendida { set { encendida = value; } get { return this.encendida; } }
        public double Dinero { get { return this.dinero; } }

        public bool EstaVacia()
        {
            if (this._latas.Count == 0) { return true; } else { return false; }
        }
        public void EncenderMaquina()
        { encendida = true; }

        public int GetCapacidadRestante()
        { return this.capacidad - this._latas.Count; }
        public int LatasCount()
        { return this._latas.Count; }

        public string GetBalance()
        { return "Cantidad de dinero: " + this.dinero; }

        public void AgregarLata(Lata nuevalata)
        {
            if (GetCapacidadRestante() > 0) { this._latas.Add(nuevalata); }
            else { throw new Exception("Operación invalida"); }
        }
        public Lata Extraerlata(string codigo, double dineroingre)
        {
            if (this.capacidad != 0)
            {
                Lata extraccion = null;
                foreach (Lata extraer in this._latas)
                {
                    if (dineroingre == extraer.PRECIO || dineroingre > extraer.PRECIO)
                    {
                        extraccion = extraer;
                        this._latas.Remove(extraer);
                        this.dinero += dineroingre;
                       
                    }
                    else
                    {
                        throw new DineroInsuficienteExcepcion();
                    }
                }
            }
            //{
                throw new SinStockExcepción();
            }

            
        }

        
    }

            
        

