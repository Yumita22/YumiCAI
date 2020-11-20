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

        private void empresasCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empresasCombo.SelectedItem != null)
           
            {
                Empresa unaEmpresa = (Empresa)empresasCombo.SelectedItem;

                EmpleadoServicio empleadoServicio = new EmpleadoServicio();
                List<Empleado> listaempleados = empleadoServicio.TraerEmpleadosPorEmpresa(unaEmpresa.Id);

                gridEmpleados.Visible = true;
                gridEmpleados.DataSource = listaempleados;

                
                                              
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna empresa");
            }


        }

        private void gridEmpleados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.gridEmpleados.Columns[0].Visible = false;
            this.gridEmpleados.Columns[1].Visible = false;
            this.gridEmpleados.Columns[2].Visible = false;
            this.gridEmpleados.Columns[4].Visible = false;
            this.gridEmpleados.Columns[5].Visible = false;
            this.gridEmpleados.Columns[8].Visible = false;
            this.gridEmpleados.Columns[11].Visible = false;
            this.gridEmpleados.Columns[12].Visible = false;
            this.gridEmpleados.Columns[13].Visible = false;
            //this.gridEmpleados.Columns[14].Visible = false;
        }
    }
    }

