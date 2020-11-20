namespace Estudio.Forms
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarLiquidaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLiquidaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.liquidacionesToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEmpleadoToolStripMenuItem,
            this.consultarEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // ingresarEmpleadoToolStripMenuItem
            // 
            this.ingresarEmpleadoToolStripMenuItem.Name = "ingresarEmpleadoToolStripMenuItem";
            this.ingresarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.ingresarEmpleadoToolStripMenuItem.Text = "Ingresar Empleado";
            this.ingresarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.ingresarEmpleadoToolStripMenuItem_Click);
            // 
            // consultarEmpleadoToolStripMenuItem
            // 
            this.consultarEmpleadoToolStripMenuItem.Name = "consultarEmpleadoToolStripMenuItem";
            this.consultarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.consultarEmpleadoToolStripMenuItem.Text = "Consultar Empleado";
            this.consultarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpleadoToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEmpresaToolStripMenuItem,
            this.consultarEmpresaToolStripMenuItem});
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // ingresarEmpresaToolStripMenuItem
            // 
            this.ingresarEmpresaToolStripMenuItem.Name = "ingresarEmpresaToolStripMenuItem";
            this.ingresarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.ingresarEmpresaToolStripMenuItem.Text = "Ingresar Empresa";
            this.ingresarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.ingresarEmpresaToolStripMenuItem_Click);
            // 
            // consultarEmpresaToolStripMenuItem
            // 
            this.consultarEmpresaToolStripMenuItem.Name = "consultarEmpresaToolStripMenuItem";
            this.consultarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.consultarEmpresaToolStripMenuItem.Text = "Consultar Empresa";
            this.consultarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpresaToolStripMenuItem_Click);
            // 
            // liquidacionesToolStripMenuItem
            // 
            this.liquidacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarLiquidaciónToolStripMenuItem,
            this.consultarLiquidaciónToolStripMenuItem});
            this.liquidacionesToolStripMenuItem.Name = "liquidacionesToolStripMenuItem";
            this.liquidacionesToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.liquidacionesToolStripMenuItem.Text = "Liquidaciones";
            // 
            // ingresarLiquidaciónToolStripMenuItem
            // 
            this.ingresarLiquidaciónToolStripMenuItem.Name = "ingresarLiquidaciónToolStripMenuItem";
            this.ingresarLiquidaciónToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.ingresarLiquidaciónToolStripMenuItem.Text = "Ingresar Liquidación";
            this.ingresarLiquidaciónToolStripMenuItem.Click += new System.EventHandler(this.ingresarLiquidaciónToolStripMenuItem_Click);
            // 
            // consultarLiquidaciónToolStripMenuItem
            // 
            this.consultarLiquidaciónToolStripMenuItem.Name = "consultarLiquidaciónToolStripMenuItem";
            this.consultarLiquidaciónToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.consultarLiquidaciónToolStripMenuItem.Text = "Consultar Liquidación";
            this.consultarLiquidaciónToolStripMenuItem.Click += new System.EventHandler(this.consultarLiquidaciónToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCategoriaToolStripMenuItem,
            this.consultarCategoriaToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // ingresarCategoriaToolStripMenuItem
            // 
            this.ingresarCategoriaToolStripMenuItem.Name = "ingresarCategoriaToolStripMenuItem";
            this.ingresarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.ingresarCategoriaToolStripMenuItem.Text = "Ingresar Categoria";
            this.ingresarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.ingresarCategoriaToolStripMenuItem_Click);
            // 
            // consultarCategoriaToolStripMenuItem
            // 
            this.consultarCategoriaToolStripMenuItem.Name = "consultarCategoriaToolStripMenuItem";
            this.consultarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.consultarCategoriaToolStripMenuItem.Text = "Consultar Categoria";
            this.consultarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.consultarCategoriaToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 255);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarLiquidaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLiquidaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCategoriaToolStripMenuItem;
    }
}