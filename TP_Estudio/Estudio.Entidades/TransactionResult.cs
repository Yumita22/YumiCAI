using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades
{
    [DataContract]
    public class TransactionResult
    
        {
            private bool _isOk;
            private int _id;
            private string _error;

            [DataMember]
            public bool IsOk { get => _isOk; set => _isOk = value; }
            [DataMember]
            public int Id { get => _id; set => _id = value; }
            [DataMember]
            public string Error { get => _error; set => _error = value; }
        }
    }



