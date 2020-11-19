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
    public partial class LiquidacionesAltas : Form
    {

       
        private LiquidacionesServicio _liquidacionesServicio;
        public LiquidacionesAltas()
        {
            InitializeComponent();
            CargarEmpleados();
            _liquidacionesServicio = new LiquidacionesServicio();
        }

        void CargarEmpleados()
        {
            try
            {
                EmpleadoServicio empleadoServicio = new EmpleadoServicio();
                List<Empleado> listaempleado = empleadoServicio.TraerEmpleados();

                this.comboLiquidaciones.DataSource = listaempleado;
                this.comboLiquidaciones.DisplayMember = "CUIL";
                this.comboLiquidaciones.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar las liquidaciones");
                this.Close();
            }

        }

        private void ingresarLiquidacion_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(transfBox.Text))
            {
                MessageBox.Show("Debe ingresar un código de transferencia");
            }
            if(string.IsNullOrEmpty(brutoBox.Text))
            {
                MessageBox.Show("Debe ingresar el monto de Sueldo Bruto");
            }
            if(!double.TryParse(brutoBox.Text, out double bruto))
            {
                MessageBox.Show("El valor del Sueldo Bruto debe ser numérico");
            }
            if (string.IsNullOrEmpty(descuentoBox.Text))
            {
                MessageBox.Show("Debe ingresar el monto de Descuentos");
            }
            if (!double.TryParse(descuentoBox.Text, out double descuentos))
            {
                MessageBox.Show("El valor de los descuentos debe ser numérico");
            }
            if(string.IsNullOrEmpty(periodoBox.Text))
            {
                MessageBox.Show("Debe ingresar el período");
            }

            if(!int.TryParse(periodoBox.Text, out int periodo))
            {
                MessageBox.Show("El período debe ser numérico");
            }

            try
            {
                int idEmpleado = (int)this.comboLiquidaciones.SelectedValue;
                int Periodo = Convert.ToInt32(this.periodoBox.Text);
                string CodigoTransferencia = this.transfBox.Text;
                double Bruto = bruto;
                double Descuentos = Convert.ToDouble(this.descuentoBox.Text);
                _liquidacionesServicio.InsertLiquidacion(idEmpleado, CodigoTransferencia, periodo, Descuentos, Bruto);
                MessageBox.Show("Se ha ingresado la liquidación exitosamente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
