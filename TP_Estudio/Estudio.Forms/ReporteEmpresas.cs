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
    public partial class ReporteEmpresas : Form
    {
        EmpresaServicio empresaServicio = new EmpresaServicio();
        public ReporteEmpresas()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            List<Empresa> listaempresa = empresaServicio.TraerEmpresas();
            gridEmpresas.Visible = true;
            gridEmpresas.DataSource = listaempresa;

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridEmpresas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.gridEmpresas.Columns[0].Visible = false;
            this.gridEmpresas.Columns[4].Visible = false;
        }
    }
}
