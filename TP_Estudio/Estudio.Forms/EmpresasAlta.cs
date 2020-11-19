using Estudio.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio.Forms
{
    public partial class EmpresasAlta : Form
    {
       
        private EmpresaServicio _empresaServicio;
        public EmpresasAlta()
        {
            InitializeComponent();
            _empresaServicio = new EmpresaServicio();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
                            
        }
               
        private void insetarEmpresa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(razonBox.Text))
            {
                MessageBox.Show("ingresar razon social");
            }
            if (string.IsNullOrEmpty(domicilioBox.Text))
            {
                MessageBox.Show("ingresar Domicilio");
            }
            if(string.IsNullOrEmpty(cuilBox.Text))
            {
                MessageBox.Show("ingresar cuil");
            }
            if (!int.TryParse(cuilBox.Text,out int cuil))
            {
                MessageBox.Show("el cuil debe ser numerico");
            }
            try
            {
                string RazonSocial = this.razonBox.Text;
                int Cuil = Convert.ToInt32(this.cuilBox.Text);
                string Domicilio = this.domicilioBox.Text;
                _empresaServicio.InsertarEmpresa(RazonSocial, Cuil, Domicilio);
                MessageBox.Show("Empresa Ingresada.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
