using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Suma_de_Dos_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double resultado = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            textBox3.Text = resultado.ToString();
        }

        private void RESTA_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            textBox3.Text = resultado.ToString();
        }

        private void MULTIPLICAR_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            textBox3.Text = resultado.ToString();
        }

        private void DIVIDIR_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            textBox3.Text = resultado.ToString();
        }
    }
}
