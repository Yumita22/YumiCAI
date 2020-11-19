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
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
            CargarEmpresas();
        }

        void CargarEmpresas()
        {
            try
            {
                EmpresaServicio empresaServicio = new EmpresaServicio();
                List<Empresa> listaempresa = empresaServicio.TraerEmpresas();

                this.empresasCombo.DataSource = listaempresa;
                this.empresasCombo.DisplayMember = "RazonSocial";
                this.empresasCombo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar las empresas");
                this.Close();
            }
        }

        void CargarEmpleados()
        {
            try
            {
                EmpleadoServicio empleadoServicio = new EmpleadoServicio();
                List<Empleado> listaempleados = empleadoServicio.TraerEmpleados();
               // var source = new BindingSource(listaempleados, null);
                dataGridView1.DataSource = listaempleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
