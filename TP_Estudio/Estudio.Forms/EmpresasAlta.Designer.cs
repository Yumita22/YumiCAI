namespace Estudio.Forms
{
    partial class EmpresasAlta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.razonBox = new System.Windows.Forms.TextBox();
            this.cuilBox = new System.Windows.Forms.TextBox();
            this.domicilioBox = new System.Windows.Forms.TextBox();
            this.insetarEmpresa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Empresas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "CUIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Domicilio";
            // 
            // razonBox
            // 
            this.razonBox.Location = new System.Drawing.Point(108, 24);
            this.razonBox.Name = "razonBox";
            this.razonBox.Size = new System.Drawing.Size(165, 25);
            this.razonBox.TabIndex = 6;
            // 
            // cuilBox
            // 
            this.cuilBox.Location = new System.Drawing.Point(108, 61);
            this.cuilBox.Name = "cuilBox";
            this.cuilBox.Size = new System.Drawing.Size(165, 25);
            this.cuilBox.TabIndex = 7;
            // 
            // domicilioBox
            // 
            this.domicilioBox.Location = new System.Drawing.Point(108, 103);
            this.domicilioBox.Name = "domicilioBox";
            this.domicilioBox.Size = new System.Drawing.Size(165, 25);
            this.domicilioBox.TabIndex = 8;
            // 
            // insetarEmpresa
            // 
            this.insetarEmpresa.Location = new System.Drawing.Point(97, 154);
            this.insetarEmpresa.Name = "insetarEmpresa";
            this.insetarEmpresa.Size = new System.Drawing.Size(137, 30);
            this.insetarEmpresa.TabIndex = 11;
            this.insetarEmpresa.Text = "Insertar Empresa";
            this.insetarEmpresa.UseVisualStyleBackColor = true;
            this.insetarEmpresa.Click += new System.EventHandler(this.insetarEmpresa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.razonBox);
            this.groupBox1.Controls.Add(this.insetarEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.domicilioBox);
            this.groupBox1.Controls.Add(this.cuilBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 199);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de Alta";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(120, 257);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(107, 26);
            this.botonVolver.TabIndex = 13;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // EmpresasAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 304);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmpresasAlta";
            this.Text = "EmpresasAlta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox razonBox;
        private System.Windows.Forms.TextBox cuilBox;
        private System.Windows.Forms.TextBox domicilioBox;
        private System.Windows.Forms.Button insetarEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonVolver;
    }
}