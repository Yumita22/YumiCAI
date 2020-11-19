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
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
           
        }

       
        private void ingresarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosAlta empleadosAlta = new EmpleadosAlta();
            empleadosAlta.Show();
                        
        }

        private void ingresarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpresasAlta empresasAlta = new EmpresasAlta();
            empresasAlta.Show();
            
        }
        private void ingresarLiquidaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiquidacionesAltas liquidacionesAltas = new LiquidacionesAltas();
            liquidacionesAltas.Show();
           
        }

        private void ingresarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriasAlta categoriasAlta = new CategoriasAlta();
            categoriasAlta.Show();
           
        }

        private void consultarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEmpleados reporteEmpleados=new ReporteEmpleados();
            reporteEmpleados.Show();
        }

        private void consultarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
