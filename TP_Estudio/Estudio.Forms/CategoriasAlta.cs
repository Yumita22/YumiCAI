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
    public partial class CategoriasAlta : Form
    {
        CategoriaServicio _categoriSservicio = new CategoriaServicio();
        public CategoriasAlta()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(categoriaBox.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la categoría");
            }
            if (string.IsNullOrEmpty(convenioBox.Text))
            {
                MessageBox.Show("Debe ingresar el convenio");
            }
            if (string.IsNullOrEmpty(sueldoBox.Text))
            {
                MessageBox.Show("Debe ingresar el sueldo");
            }
            if (!double.TryParse(sueldoBox.Text, out double _sueldo))
            {
                MessageBox.Show("El sueldo debe ser numérico");
            }

            try

            {
                string Nombre = categoriaBox.Text;
                string Convenio = convenioBox.Text;
                double Sueldo = _sueldo;
                _categoriSservicio.InsertarCategoria(Nombre, Convenio, Sueldo);
                MessageBox.Show("La categoría ha sido ingresada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
