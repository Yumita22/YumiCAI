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

         public int InsertarEmpleado(int idEmpresa, int idCategoria, long cuil, DateTime fechaNacimiento, string nombre, string apellido)
        {
            ValidarDatos(idEmpresa, idCategoria, cuil, fechaNacimiento, nombre, apellido);
            Empleado empleado = new Empleado();
            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.idEmpresa = idEmpresa;
            empleado.idCategoria = idCategoria;
            empleado.cuil = cuil;
            empleado.fechaNacimientoDateTime = fechaNacimiento;
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

        public void ValidarDatos(int idEmpresa, int idCategoria, long cuil, DateTime fechaNacimiento, string nombre, string apellido)
        {
            //Valida empresa
            EmpresaServicio empresaServicio = new EmpresaServicio();
            if (!empresaServicio.Existe(idEmpresa))
            {
                throw new ArgumentException("No existe la empresa");
            }

            //Valida Categoria
            CategoriaServicio categoriaServicio = new CategoriaServicio();
            if (!categoriaServicio.Existe(idCategoria))
            {
                throw new ArgumentException("No existe la categoria");
            }

            //validar cuil  buscar empleados por cuil  
            List<Empleado> empleadosEmpresa = TraerEmpleadosPorEmpresa(idEmpresa);
            foreach (Empleado c in empleadosEmpresa)
            {
                if (c.cuil == cuil)
                {
                    throw new ArgumentException("El empleado ya existe para esta empresa");
                }
            }

            //validar fecha nacimeinto >18 años
            TimeSpan diferencia = DateTime.Now - fechaNacimiento;
            if ((diferencia.TotalDays / 365) < 18)
            {
                throw new ArgumentException("El empleado es menor de edad");
            }

            //validar nombre
            if (String.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("Debe ingresar un nombre");
            }

            //validar apellid
            if (String.IsNullOrWhiteSpace(apellido))
            {
                throw new ArgumentException("Debe ingresar un Apellido");
            }

        }
    }
}

