namespace Suma_de_Dos_Numeros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SUMA = new System.Windows.Forms.Button();
            this.RESTA = new System.Windows.Forms.Button();
            this.MULTIPLICAR = new System.Windows.Forms.Button();
            this.DIVIDIR = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numero1 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 0;
            // 
            // SUMA
            // 
            this.SUMA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SUMA.Location = new System.Drawing.Point(43, 322);
            this.SUMA.Name = "SUMA";
            this.SUMA.Size = new System.Drawing.Size(109, 62);
            this.SUMA.TabIndex = 1;
            this.SUMA.Text = "SUMA";
            this.SUMA.UseVisualStyleBackColor = false;
            this.SUMA.Click += new System.EventHandler(this.button1_Click);
            // 
            // RESTA
            // 
            this.RESTA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RESTA.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RESTA.Location = new System.Drawing.Point(185, 322);
            this.RESTA.Name = "RESTA";
            this.RESTA.Size = new System.Drawing.Size(109, 62);
            this.RESTA.TabIndex = 2;
            this.RESTA.Text = "RESTA";
            this.RESTA.UseVisualStyleBackColor = false;
            this.RESTA.Click += new System.EventHandler(this.RESTA_Click);
            // 
            // MULTIPLICAR
            // 
            this.MULTIPLICAR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MULTIPLICAR.Location = new System.Drawing.Point(318, 322);
            this.MULTIPLICAR.Name = "MULTIPLICAR";
            this.MULTIPLICAR.Size = new System.Drawing.Size(109, 62);
            this.MULTIPLICAR.TabIndex = 3;
            this.MULTIPLICAR.Text = "MULTIPLICACION";
            this.MULTIPLICAR.UseVisualStyleBackColor = false;
            this.MULTIPLICAR.Click += new System.EventHandler(this.MULTIPLICAR_Click);
            // 
            // DIVIDIR
            // 
            this.DIVIDIR.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DIVIDIR.Location = new System.Drawing.Point(453, 322);
            this.DIVIDIR.Name = "DIVIDIR";
            this.DIVIDIR.Size = new System.Drawing.Size(109, 62);
            this.DIVIDIR.TabIndex = 4;
            this.DIVIDIR.Text = "DIVICION";
            this.DIVIDIR.UseVisualStyleBackColor = false;
            this.DIVIDIR.Click += new System.EventHandler(this.DIVIDIR_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 6;
            // 
            // numero1
            // 
            this.numero1.AutoSize = true;
            this.numero1.Location = new System.Drawing.Point(107, 39);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(53, 13);
            this.numero1.TabIndex = 7;
            this.numero1.Text = "Numero 1";
            // 
            // numero2
            // 
            this.numero2.AutoSize = true;
            this.numero2.Location = new System.Drawing.Point(107, 112);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(53, 13);
            this.numero2.TabIndex = 8;
            this.numero2.Text = "Nemero 2";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(107, 183);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(55, 13);
            this.resultado.TabIndex = 9;
            this.resultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 396);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DIVIDIR);
            this.Controls.Add(this.MULTIPLICAR);
            this.Controls.Add(this.RESTA);
            this.Controls.Add(this.SUMA);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SUMA;
        private System.Windows.Forms.Button RESTA;
        private System.Windows.Forms.Button MULTIPLICAR;
        private System.Windows.Forms.Button DIVIDIR;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label numero1;
        private System.Windows.Forms.Label numero2;
        private System.Windows.Forms.Label resultado;
    }
}

