using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculator
{
    public class ClassCalculadora
    {
        private float Numero1;
        private float Numero2;

        public float Numero11 { get => Numero1; set => Numero1 = value; }
        public float Numero21 { get => Numero2; set => Numero2 = value; }

        static float Suma(float Numero1, float Numero2)
        {   
            float result = Numero1 + Numero2;   return result;
        }

        static float Resta(float Numero1, float Numero2)
        {
            float result = Numero1 - Numero2;    return result;
        }

        static float Multiplicacion(float Numero1, float Numero2)
        {
            float result = Numero1 * Numero2;   return result;
        }

        static float Division(float Numero1, float Numero2)
        {
            if(Numero2 != 0)
            {
                float result = Numero1 + Numero2; 
                return result;
            }
            else
            {
                Console.WriteLine("No se puede dividir en 0");
            }
        }
    }
}
