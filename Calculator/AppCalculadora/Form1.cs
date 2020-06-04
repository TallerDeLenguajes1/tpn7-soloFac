using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        Calculadora MiCalculadora;

        public Form1()
        {
            InitializeComponent();
            MiCalculadora = new Calculadora();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            
            
        }

        
        private void button12_Click(object sender, EventArgs e)
        {
            
            char[] Operadores = { '+', '-', '*', '/' };

            string result = textBox1.Text;
            textBox1.Text = "";

            string[] resultado = new string[] { "0" };

            foreach (char c in Operadores)
            {
                resultado = result.Split(c);

                MiCalculadora.Numero1 = Convert.ToSingle(resultado[0]);
                MiCalculadora.Numero2 = Convert.ToSingle(resultado[1]);

                /*
                if (resultado[0] != null)
                {
                    MiCalculadora.Numero1 = Convert.ToSingle(resultado[0]);
                    MiCalculadora.Numero2 = Convert.ToSingle(resultado[1]);
                }
                */
            }

            textBox1.Text = resultado[0];
        }
        

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int lng = textBox1.Text.Length;

            if(lng > 0)
            {
                textBox1.Text = textBox1.Text.Remove(lng - 1);
            }

        }
    }
}
