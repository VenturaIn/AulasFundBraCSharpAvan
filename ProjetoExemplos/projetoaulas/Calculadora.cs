using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class Calculadora : Form
    {
        private string numeros;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            this.numeros = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.numeros += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.numeros += "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.numeros += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = 0;

            foreach (char c in this.numeros)
            {
                result += int.Parse(c.ToString());
            }

            textBox1.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = 0;

            foreach (char c in this.numeros)
            {
                result = result - int.Parse(c.ToString());
            }

            textBox1.Text = result.ToString();
        }
    }
}
