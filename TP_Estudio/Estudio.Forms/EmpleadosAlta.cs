using Estudio.Entidades;
using Estudio.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio.Forms
{
    public partial class EmpleadosAlta : Form
    {
       
        private EmpleadoServicio _empleadoServicio;
        public EmpleadosAlta()
        {
            InitializeComponent();
            CargarEmpresas();
            CargarCategorias();
            _empleadoServicio = new EmpleadoServicio();

        }

        
        public void CargarEmpresas()
        {
            try
            {
                EmpresaServicio empresaServicio = new EmpresaServicio();
                List<Empresa> listaempresa = empresaServicio.TraerEmpresas();

                this.empresaCombo.DataSource = listaempresa;
                this.empresaCombo.DisplayMember = "RazonSocial";
                this.empresaCombo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar las empresas");
                this.Close();
            }
        }


        void CargarCategorias()
        {
            try
            {
                CategoriaServicio categoriaServicio = new CategoriaServicio();
                List<Categoria> listacategoria = categoriaServicio.GetCategorias();
                this.categoriaCombo.DataSource = listacategoria;
                this.categoriaCombo.DisplayMember = "Nombre";
                this.categoriaCombo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar las categorias");
                this.Close();
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }



        private void InsertarEmpleado_Click(object sender, EventArgs e)
        {
          
            try
            {
                string Nombre = this.nombretxt.Text;
                string Apellido = this.apellidotxt.Text;
                int idEmpresa = (int)this.empresaCombo.SelectedValue;
                int idCategoria = (int)this.categoriaCombo.SelectedValue;
                long Cuil;
                if (!long.TryParse(this.cuilTxt.Text, out Cuil))
                {
                    throw new ArgumentException("El cuil debe ser numerico");
                }
                DateTime FechaNacimiento = this.fechanacPicker.Value;
                
                _empleadoServicio.InsertarEmpleado(idEmpresa, idCategoria, Cuil, FechaNacimiento, Nombre, Apellido);
                MessageBox.Show("El empleado fue ingresado exitosamente");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Error del servidor");
            }
        }


    }


}
