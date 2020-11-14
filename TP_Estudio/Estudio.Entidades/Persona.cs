using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades
{
    [DataContract]
    public class Persona
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private long _telefono;
        private string _mail;

        public Persona(int Id, string Nombre, string Apellido, string Direccion, long Telefono, string Mail)
        {
            this._id = Id;
            this._nombre = Nombre;
            this._apellido = Apellido;
            this._direccion = Direccion;
            this._telefono = Telefono;
            this._mail = Mail;
            
        }

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember]
        public string Apellido { get => _apellido; set => _apellido = value; }
        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }
        [DataMember]
        public long Telefono { get => _telefono; set => _telefono = value; }
        [DataMember]
        public string Mail { get => _mail; set => _mail = value; }
    }
}
