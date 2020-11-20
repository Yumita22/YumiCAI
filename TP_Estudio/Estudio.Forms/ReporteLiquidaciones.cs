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
    public partial class ReporteLiquidaciones : Form
    {
        public ReporteLiquidaciones()
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
                comboCategoria.DataSource = listacategorias;
                comboCategoria.DisplayMember = "Nombre";
                comboCategoria.ValueMember = "id";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al cargar las categorías");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(comboCategoria.SelectedItem!=null)
            {
                Categoria unaCategoria = (Categoria)comboCategoria.SelectedItem;
                LiquidacionesServicio liquidacionesServicio = new LiquidacionesServicio();
                List < Liquidaciones > liquidaciones = liquidacionesServicio.TraerLiquidacionesPorCategoria(unaCategoria.Id);
                gridLiquidaciones.DataSource = liquidaciones;
                gridLiquidaciones.Visible = true;



            }

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
