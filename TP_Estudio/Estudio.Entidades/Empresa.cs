using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades
{
    [DataContract]
    public class Empresa
    {
        private int _id;
        private string _razonSocial;
        private long _cuil;
        private string _domicilio;
        private DateTime _fechaAlta;

        public Empresa(string razonSocial, long cuil, string domicilio)
        {
            
            this._razonSocial = razonSocial;
            this._cuil = cuil;
            this._domicilio = domicilio;
            
        }

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        [DataMember]
        public long Cuil { get => _cuil; set => _cuil = value; }
        [DataMember]
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        [DataMember]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    }
}
