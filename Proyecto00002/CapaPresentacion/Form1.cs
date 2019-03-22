using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            r = a + b;
            label3.Text = "Resultado = "+r.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, r;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            r = a - b;
            label3.Text = "Resultado = " + r.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, r;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            r = a * b;
            label3.Text = "Resultado = " + r.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, r;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            if (b == 0)
            {
                label3.Text = "ERROR";
            }
            else
            {
                r = a / b;
                label3.Text = "Resultado = " + r.ToString();
            }
        }
    }
}
