using Estudio.Datos;
using Estudio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocios
{
    public class EmpleadoServicio
    
        {
            private EmpleadoMapper mapper;
            public EmpleadoServicio()
            {
                mapper = new EmpleadoMapper();
            }
            public List<Empleado> TraerEmpleados()
            {
                List<Empleado> result = mapper.TraerTodos();
                return result;
            }
        
            public List<Empleado> TraerEmpleadosPorEmpresa(int idEmpresa)
            {
                List<Empleado> empleadoIdEmpresa = new List<Empleado>();
                foreach (Empleado c in this.TraerEmpleados())
                {
                    if (c.idEmpresa == idEmpresa)
                    {
                        empleadoIdEmpresa.Add(c);
                    }
                }
                return empleadoIdEmpresa;
            }
            public int InsertarEmpleado(int idEmpleado, int idEmpresa, int idCategoria, long cuil, DateTime fechaNacimiento, DateTime fechaAlta)
            {
               Empleado empleado = new Empleado(idEmpleado,idEmpresa,idCategoria,cuil,fechaNacimiento,fechaAlta);
                empleado.idEmpleado = idEmpleado;
                empleado.idEmpresa = idEmpresa;
                empleado.idCategoria = idCategoria;
                empleado.cuil = cuil;
                empleado.fechaNacimiento = fechaNacimiento;
                empleado.fechaAlta = fechaAlta;
                empleado.activo = true;
                TransactionResult resultante = mapper.Insert(empleado);
             
                if (resultante.IsOk)
                {
                    return resultante.Id;
                }
                else
                {
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
                }
            }
            internal bool Existe(int idEmpleado)
            {
                List<Empleado> lst = TraerEmpleados();
                foreach (Empleado c in lst)
                {
                    if (idEmpleado == c.Id)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }

