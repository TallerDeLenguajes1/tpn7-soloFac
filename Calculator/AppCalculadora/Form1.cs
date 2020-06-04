using System;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        Calculadora MiCalculadora;

        string estado = "OpNoAsignado";
        string operador;
        float Num1=0, Num2=0, resultado=0;

        public Form1()
        {
            InitializeComponent();
            MiCalculadora = new Calculadora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "1";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(estado == "OpNoAsignado")
            {
                textBoxInf.Text += "2";
                MiCalculadora.Numero1 = Convert.ToSingle(textBoxInf.Text);
            }else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "2";
                MiCalculadora.Numero2 = Convert.ToSingle(textBoxInf.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "3";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "4";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "5";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "6";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "7";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "8";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "9";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "9";
            }
        }

        
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textBoxInf.Text += ".";
        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            if (estado == "OpNoAsignado")
            {
                textBoxInf.Text += "0";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == "OpAsignado")
            {
                textBoxInf.Text += "0";
            }
        }


        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if(operador == "OpAsignado")
            {
                Num2 = Convert.ToSingle(textBoxInf.Text);

                resultado = MiCalculadora.Suma(MiCalculadora.Numero1, MiCalculadora.Numero2);

                textBoxSup.Text = resultado.ToString();

            }
            /*
            char[] Operadores = { '+', '-', '*', '/' };

            string result = textBox1.Text;
            textBox1.Text = "";

            string[] cadena = new string[] { "0" };
            string operador = "0";


            foreach (char op in Operadores)
            {
                int posicion = result.IndexOf(op);

                if (posicion != -1)
                {
                    int StartIndex = posicion;
                    int lenght = 1;

                    operador = result.Substring(StartIndex, lenght);

                    cadena = result.Split(Convert.ToChar(operador));

                    MiCalculadora.Numero1 = Convert.ToSingle(cadena[0]);
                    MiCalculadora.Numero2 = Convert.ToSingle(cadena[1]);

                    float r = 0;

                    r = MiCalculadora.Suma(MiCalculadora.Numero1, MiCalculadora.Numero2);

                    textBox1.Text = r.ToString();

                    //cadena = result.Remove();
                }
            }
            */
            /*
            foreach (char c in Operadores)
            {
                resultado = result.Split(c);

                
                MiCalculadora.Numero1 = Convert.ToSingle(resultado[0]);
                MiCalculadora.Numero2 = Convert.ToSingle(resultado[1]);
               
                if (String.IsNullOrWhiteSpace(resultado[0]) == false && String.IsNullOrWhiteSpace(resultado[1]) == false)
                {
                    MiCalculadora.Numero1 = Convert.ToSingle(resultado[0]);
                    MiCalculadora.Numero2 = Convert.ToSingle(resultado[1]);
                } 
                
            }
            */


            //textBox1.Text = MiCalculadora.Numero1.ToString();
        }


        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (Num1.ToString() != "" && operador == "OpNoAsignado")
            {
                operador = "/";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = "OpAsignado";
            }
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (Num1.ToString() != "" && operador == "OpNoAsignado")
            {
                operador = "*";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = "OpAsignado";
            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (Num1.ToString() != "" == true && operador == "OpNoAsignado")
            {
                operador = "-";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = "OpAsignado";
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if(Num1.ToString() != "" && operador == "OpAsignado")
            {
                operador = "+";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = "OpAsignado";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            estado = "OpNoAsignado";
            textBoxInf.Text = "";
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int lng = textBoxInf.Text.Length;

            if (lng > 0)
            {
                textBoxInf.Text = textBoxInf.Text.Remove(lng - 1);
            }
        }


        public void Seleccion()
        {
            
        }
    }
}
