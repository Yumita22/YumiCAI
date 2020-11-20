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
    public partial class ReporteCategorias : Form
    {
        public ReporteCategorias()
        {
            InitializeComponent();
            CargarCategorias();
        }

        void CargarCategorias()
        {
            try
            {
                CategoriaServicio categoriaServicio = new CategoriaServicio();
                List<Categoria> listacategorias = categoriaServicio.GetCategorias();
                this.comboConvenio.DataSource = listacategorias;
                this.comboConvenio.DisplayMember = "Convenio";
                this.comboConvenio.ValueMember = "id";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al cargar los convenios");
                this.Close();
            }
            

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboConvenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboConvenio.SelectedItem!=null)
            {
                Categoria unaCategoria = (Categoria)comboConvenio.SelectedItem;
                CategoriaServicio categoriaServicio = new CategoriaServicio();
                List<Categoria> categorias = categoriaServicio.GetCategoriasPorConvenio(unaCategoria.Convenio);
                gridCategorias.Visible = true;
                gridCategorias.DataSource = categorias;


            }
        }
    }
}
