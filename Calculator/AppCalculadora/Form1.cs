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

            textBoxInf.KeyDown += textBoxInf_KeyDown;
            textBoxInf.KeyPress += textBoxInf_KeyPress;
            textBoxInf.KeyUp += textBoxInf_KeyUp;
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

        private void button2_Click(object sender, EventArgs e)  //Deberia hacer un trim?
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
            if(estado == "OpAsignado")
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
            if (Num1.ToString() != "" && estado == "OpNoAsignado")
            {
                operador = "/";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = "OpAsignado";
            }
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (Num1.ToString() != "" && estado == "OpNoAsignado")
            {
                operador = "*";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = "OpAsignado";
            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (Num1.ToString() != "" == true && estado == "OpNoAsignado")
            {
                operador = "-";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = "OpAsignado";
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if(Num1.ToString() != "" && estado == "OpAsignado")
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

        /*
        private bool noNumeroIngresado = false;
        private void textBoxInf_KeyDown(object sender, KeyEventArgs e)
        {
            noNumeroIngresado = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        noNumeroIngresado = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                noNumeroIngresado = true;
            }
        }

        
        private void textBoxInf_KeyPress(object sender, KeyPressEventArgs e)
        {
            noNumeroIngresado = false;
            // Check for the flag being set in the KeyDown event.
            if (noNumeroIngresado == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
                textBoxInf.Text += e.KeyChar.ToString();
            }
        }
        */
        //-----------------------------------------------------------

        // Handle the KeyUp event to print the type of character entered into the control.
        private void textBoxInf_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxSup.AppendText($"KeyUp code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
        }

        // Handle the KeyPress event to print the type of character entered into the control.
        private void textBoxInf_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxSup.AppendText($"KeyPress keychar: {e.KeyChar}" + "\r\n");
        }

        // Handle the KeyDown event to print the type of character entered into the control.
        private void textBoxInf_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxSup.AppendText($"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
        }

        //-----------------------------------------------------------


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
