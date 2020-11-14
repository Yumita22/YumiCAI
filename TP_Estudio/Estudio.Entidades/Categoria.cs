using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades
{
    [DataContract]
    public class Categoria
    {
        private int _id;
        private string _nombre;
        private string _convenio;
        private double _sueldoBasico;

        public Categoria(int id, string nombre, string convenio, double sueldoBasico)
        {
            this._id = id;
            this._nombre = nombre;
            this._convenio = convenio;
            this._sueldoBasico = sueldoBasico;
        }

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember]
        public string Convenio { get => _convenio; set => _convenio = value; }
        [DataMember]
        public double SueldoBasico { get => _sueldoBasico; set => _sueldoBasico = value; }
    }
}
