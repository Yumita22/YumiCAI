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
    }
}
