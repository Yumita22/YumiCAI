namespace Estudio.Forms
{
    partial class ReporteCategorias
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.botonVolver = new System.Windows.Forms.Button();
            this.comboConvenio = new System.Windows.Forms.ComboBox();
            this.labelconvenio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de Categorias";
            // 
            // gridCategorias
            // 
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.Location = new System.Drawing.Point(56, 111);
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.Size = new System.Drawing.Size(524, 168);
            this.gridCategorias.TabIndex = 1;
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(275, 297);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // comboConvenio
            // 
            this.comboConvenio.FormattingEnabled = true;
            this.comboConvenio.Location = new System.Drawing.Point(216, 69);
            this.comboConvenio.Name = "comboConvenio";
            this.comboConvenio.Size = new System.Drawing.Size(121, 25);
            this.comboConvenio.TabIndex = 3;
            this.comboConvenio.SelectedIndexChanged += new System.EventHandler(this.comboConvenio_SelectedIndexChanged);
            // 
            // labelconvenio
            // 
            this.labelconvenio.AutoSize = true;
            this.labelconvenio.Location = new System.Drawing.Point(53, 72);
            this.labelconvenio.Name = "labelconvenio";
            this.labelconvenio.Size = new System.Drawing.Size(136, 17);
            this.labelconvenio.TabIndex = 4;
            this.labelconvenio.Text = "Seleccionar Convenio";
            // 
            // ReporteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 354);
            this.Controls.Add(this.labelconvenio);
            this.Controls.Add(this.comboConvenio);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.gridCategorias);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteCategorias";
            this.Text = "ReporteCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCategorias;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.ComboBox comboConvenio;
        private System.Windows.Forms.Label labelconvenio;
    }
}