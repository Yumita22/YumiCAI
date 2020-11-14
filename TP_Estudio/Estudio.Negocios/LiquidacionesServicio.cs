using Estudio.Datos;
using Estudio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocios
{
    public class LiquidacionesServicio
    {
        private LiquidacionesMapper mapper;
        public LiquidacionesServicio()
        {
            mapper = new LiquidacionesMapper ();
        }
        public List<Liquidaciones> TraerLiquidaciones()
        {
            List<Liquidaciones> result = mapper.TraerTodos();
            return result;
        }

        public List<Liquidaciones> TraerLiquidacionesPorCategoria(int idCategoria)
        {
            List<Liquidaciones> LiquidacionCategoria = new List<Liquidaciones>();
            foreach (Liquidaciones c in this.TraerLiquidaciones())
            {
                if (c.Id == idCategoria)
                {
                    LiquidacionCategoria.Add(c);
                }
            }
            return LiquidacionCategoria;
        }
        public int InsertLiquidacion(int id, int idEmpleado, int codigoTransferencia, int periodo, double bruto, double descuentos, DateTime fechaAlta)
        {
            Liquidaciones liquidaciones = new Liquidaciones(id,idEmpleado,codigoTransferencia,periodo,bruto,descuentos,fechaAlta);
            liquidaciones.Id = id;
            liquidaciones.IdEmpleado = idEmpleado;
            liquidaciones.CodigoTransferencia = codigoTransferencia;
            liquidaciones.Periodo = periodo;
            liquidaciones.Bruto = bruto;
            liquidaciones.Descuentos = descuentos;
            liquidaciones.FechaAlta = fechaAlta;
            TransactionResult resultante = mapper.Insert(liquidaciones);

            if (resultante.IsOk)
            {
                return resultante.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
            }
        }
        internal bool Existe(int id)
        {
            List<Liquidaciones> lst = TraerLiquidaciones();
            foreach (Liquidaciones c in lst)
            {
                if (id == c.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

