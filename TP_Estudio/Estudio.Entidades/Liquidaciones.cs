using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades
{
    [DataContract]
    public class Liquidaciones
    {
        private int _id;
        private int _idEmpleado;
        private string _codigoTransferencia;
        private int _periodo;
        private double _bruto;
        private double _descuentos;
        private DateTime _fechaAlta;

        public Liquidaciones(int idEmpleado, string codigoTransferencia, int periodo, double bruto, double descuentos)
        {
            //this._id = id;
            this._idEmpleado = idEmpleado;
            this._codigoTransferencia = codigoTransferencia;
            this._periodo = periodo;
            this._bruto = bruto;
            this._descuentos = descuentos;
           
        }

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        [DataMember]
        public string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        [DataMember]
        public int Periodo { get => _periodo; set => _periodo = value; }
        [DataMember]
        public double Bruto { get => _bruto; set => _bruto = value; }
        [DataMember]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        [DataMember]
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
    }
}
