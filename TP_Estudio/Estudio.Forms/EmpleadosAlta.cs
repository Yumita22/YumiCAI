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
        public EmpleadosAlta()
        {
            InitializeComponent();
            CargarEmpresas();
            CargarCategorias();
           
        }

      void CargarEmpresas()
        {
            try
            {
                EmpresaServicio empresaServicio = new EmpresaServicio();
                List<Empresa> listaempresa = empresaServicio.TraerEmpresas();

                this.empresaCombo.DataSource = listaempresa;
                this.empresaCombo.DisplayMember = "RazonSocial";
                this.empresaCombo.ValueMember = "Id";
            }
            catch(Exception ex) 
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

    }
}
