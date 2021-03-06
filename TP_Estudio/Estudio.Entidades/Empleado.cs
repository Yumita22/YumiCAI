﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades
{
    [DataContract]
    public class Empleado : Persona
    {
        #region Atributos y propiedades

        private int _idEmpleado;
        private int _idEmpresa;
        private int _idCategoria;
        private long _cuil;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;


        [DataMember]
        public int idEmpleado { get => _idEmpleado; set => _idEmpleado = value; }

        [DataMember]
        public int idEmpresa { get => _idEmpresa; set => _idEmpresa = value; }

        [DataMember]
        public int idCategoria { get => _idCategoria; set => _idCategoria = value; }

        [DataMember]
        public long cuil { get => _cuil; set => _cuil = value; }

        [DataMember]
        public DateTime fechaNacimientoDateTime { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public string fechaNacimiento
        { 
            set 
            {
                /* Intenta convertir el valor en fecha */
                DateTime aux;
                if (DateTime.TryParse(value, out aux)) 
                {
                    _fechaNacimiento = aux;
                }
            }
            get {
                return _fechaNacimiento.ToString();
            }
        }

        [DataMember]
        public DateTime fechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        [DataMember]
        public bool activo { get => _activo; set => _activo = value; }

 
    }
}
#endregion