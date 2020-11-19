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
    public partial class ValidarLegajo : Form
    {
        
        public ValidarLegajo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(legajoBox.Text))
            {
                MessageBox.Show("Debe ingresar su numero de legajo");
            }
            else if(!int.TryParse(legajoBox.Text, out int legajo))
            {
                MessageBox.Show("El legajo debe ser numérico");
            }
            else if(legajo!=881113)
            {
                MessageBox.Show("Ud no está autorizado a ingresar");
            }
            else
            {
                Inicio inicio = new Inicio();
                inicio.Show();
               
            }


        }
    }
}
