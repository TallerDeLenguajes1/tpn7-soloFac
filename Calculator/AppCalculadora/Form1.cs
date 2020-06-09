using System;
using System.Windows.Forms;

namespace AppCalculadora
{
    enum EstadoOperador 
    {
        OperadorNoAsignado = 1,
        OperadorAsignado = 2
    }

    enum TeclaPresionada
    {
        TeclaNumerica ,
        TeclaBack ,
        TeclaOperador,
        TeclaNoValida
    }

    public partial class Form1 : Form
    {
        Calculadora MiCalculadora;

        EstadoOperador estado = EstadoOperador.OperadorNoAsignado;
        string operador;
        float Num1=0, Num2=0, resultado=0;
        TeclaPresionada MiTeclaPresionada;
        public Form1()
        {
            InitializeComponent();
            MiCalculadora = new Calculadora();

            textBoxInf.KeyDown += textBoxInf_KeyDown;
            textBoxInf.KeyPress += textBoxInf_KeyPress;
            button1.Click += BtnNumerico_Click;
            button2.Click += BtnNumerico_Click;
            button3.Click += BtnNumerico_Click;
            button4.Click += BtnNumerico_Click;
            button5.Click += BtnNumerico_Click;
            button6.Click += BtnNumerico_Click;
            button7.Click += BtnNumerico_Click;
            button8.Click += BtnNumerico_Click;
            button9.Click += BtnNumerico_Click;
            button9.Click += BtnNumerico_Click;
            button11.Click += BtnNumerico_Click;
            //textBoxInf.KeyUp += textBoxInf_KeyUp;
        }

        private void BtnNumerico_Click(object sender, EventArgs e)
        {
            string TextoBoton = ((Button)sender).Text;
            PresionDeNumero(TextoBoton);
        }

        public void PresionDeNumero(string NumeroPresionado)
        {
            if (estado == EstadoOperador.OperadorNoAsignado)
            {
                textBoxInf.Text += NumeroPresionado;
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == EstadoOperador.OperadorAsignado)
            {
                textBoxInf.Text += NumeroPresionado;
            }         
        }

        
        
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textBoxInf.Text += ".";
            float Nombre = 123.2f;

        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            if (estado == EstadoOperador.OperadorNoAsignado)
            {
                textBoxInf.Text += "0";
                Num1 = Convert.ToSingle(textBoxInf.Text.Trim());
            }
            else if (estado == EstadoOperador.OperadorAsignado)
            {
                textBoxInf.Text += "0";
            }
        }


        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if(estado == EstadoOperador.OperadorAsignado)
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
            if (Num1.ToString() != "" && estado == EstadoOperador.OperadorNoAsignado)
            {
                operador = "/";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = EstadoOperador.OperadorAsignado;
            }
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (Num1.ToString() != "" && estado == EstadoOperador.OperadorNoAsignado)
            {
                operador = "*";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = EstadoOperador.OperadorAsignado;
            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (Num1.ToString() != "" == true && estado == EstadoOperador.OperadorNoAsignado)
            {
                operador = "-";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = EstadoOperador.OperadorAsignado;
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if(Num1.ToString() != "" && estado == EstadoOperador.OperadorAsignado)
            {
                operador = "+";
                textBoxSup.Text = Num1.ToString() + operador;
                textBoxInf.Text = "";
                estado = EstadoOperador.OperadorAsignado;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            estado = EstadoOperador.OperadorNoAsignado;
            textBoxInf.Text = "";
        }


        
        private void textBoxInf_KeyDown(object sender, KeyEventArgs e)
        {
            MiTeclaPresionada = TeclaPresionada.TeclaNoValida;
          
            if ((e.KeyCode > Keys.D0 && e.KeyCode < Keys.D9) ||
                    (e.KeyCode > Keys.NumPad0 && e.KeyCode < Keys.NumPad9))               
            {
                MiTeclaPresionada = TeclaPresionada.TeclaNumerica;
            }

            if (e.KeyCode == Keys.Add)
            {
                MiTeclaPresionada = TeclaPresionada.TeclaOperador;
            }

            if ((e.KeyCode == Keys.Back))
            {
                MiTeclaPresionada = TeclaPresionada.TeclaBack;                
            }
            
            if (Control.ModifierKeys == Keys.Shift)
            {
                MiTeclaPresionada = TeclaPresionada.TeclaNoValida;
            }
        }


        private void textBoxInf_KeyPress(object sender, KeyPressEventArgs e)
        {                    
            if (MiTeclaPresionada == TeclaPresionada.TeclaNoValida)
            {               
                e.Handled = true;             
            }
        }

        //-----------------------------------------------------------

        // Handle the KeyUp event to print the type of character entered into the control.
        //private void textBoxInf_KeyUp(object sender, KeyEventArgs e)
        //{
        //    textBoxSup.AppendText($"KeyUp code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
        //}

        //// Handle the KeyPress event to print the type of character entered into the control.
        //private void textBoxInf_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    textBoxSup.AppendText($"KeyPress keychar: {e.KeyChar}" + "\r\n");
        //}

        //// Handle the KeyDown event to print the type of character entered into the control.
        //private void textBoxInf_KeyDown(object sender, KeyEventArgs e)
        //{
        //    textBoxSup.AppendText($"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
        //}

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
