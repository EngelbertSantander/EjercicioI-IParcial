namespace Ejercicio1_IParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTextBox1 = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcularButton1 = new System.Windows.Forms.Button();
            this.LimpiarButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número entero:";
            // 
            // NumeroTextBox1
            // 
            this.NumeroTextBox1.Location = new System.Drawing.Point(359, 141);
            this.NumeroTextBox1.Name = "NumeroTextBox1";
            this.NumeroTextBox1.Size = new System.Drawing.Size(322, 22);
            this.NumeroTextBox1.TabIndex = 1;
            // 
            // ResultadoTextBox2
            // 
            this.ResultadoTextBox2.Location = new System.Drawing.Point(359, 210);
            this.ResultadoTextBox2.Name = "ResultadoTextBox2";
            this.ResultadoTextBox2.Size = new System.Drawing.Size(322, 22);
            this.ResultadoTextBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado:";
            // 
            // CalcularButton1
            // 
            this.CalcularButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton1.Location = new System.Drawing.Point(148, 301);
            this.CalcularButton1.Name = "CalcularButton1";
            this.CalcularButton1.Size = new System.Drawing.Size(187, 51);
            this.CalcularButton1.TabIndex = 6;
            this.CalcularButton1.Text = "Calcular";
            this.CalcularButton1.UseVisualStyleBackColor = true;
            this.CalcularButton1.Click += new System.EventHandler(this.CalcularButton1_Click);
            // 
            // LimpiarButton2
            // 
            this.LimpiarButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton2.Location = new System.Drawing.Point(437, 301);
            this.LimpiarButton2.Name = "LimpiarButton2";
            this.LimpiarButton2.Size = new System.Drawing.Size(187, 51);
            this.LimpiarButton2.TabIndex = 7;
            this.LimpiarButton2.Text = "Limpiar";
            this.LimpiarButton2.UseVisualStyleBackColor = true;
            this.LimpiarButton2.Click += new System.EventHandler(this.LimpiarButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 448);
            this.Controls.Add(this.LimpiarButton2);
            this.Controls.Add(this.CalcularButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultadoTextBox2);
            this.Controls.Add(this.NumeroTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTextBox1;
        private System.Windows.Forms.TextBox ResultadoTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalcularButton1;
        private System.Windows.Forms.Button LimpiarButton2;
    }
}

