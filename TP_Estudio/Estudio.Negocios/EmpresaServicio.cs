using Estudio.Datos;
using Estudio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocios
{
    public class EmpresaServicio
    {
        private EmpresaMapper mapper;
        public EmpresaServicio()
        {
            mapper = new EmpresaMapper();
        }
        public List<Empresa> TraerEmpresas()
        {
            List<Empresa> result = mapper.TraerTodos();
            return result;
        }

        public int InsertarEmpresa(string razonSocial, long cuil, string domicilio)
        {
            Empresa empresa = new Empresa(razonSocial,cuil,domicilio);
           // empresa.Id = idEmpresa;
            empresa.RazonSocial = razonSocial;
            empresa.Cuil = cuil;
            empresa.Domicilio = domicilio;
           // empresa.FechaAlta = fechaAlta;
            TransactionResult resultante = mapper.Insert(empresa);

            if (resultante.IsOk)
            {
                return resultante.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
            }
        }
        internal bool Existe(int idEmpresa)
        {
            List<Empresa> lst = TraerEmpresas();
            foreach (Empresa c in lst)
            {
                if (idEmpresa == c.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
