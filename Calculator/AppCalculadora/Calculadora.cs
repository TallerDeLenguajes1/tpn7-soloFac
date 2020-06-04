using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    public class Calculadora
    {
        private float numero1;
        private float numero2;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        public float Suma(float Numero1, float Numero2)
        {
            float result = Numero1 + Numero2; return result;
        }

        float Resta(float Numero1, float Numero2)
        {
            float result = Numero1 - Numero2; return result;
        }

        float Multiplicacion(float Numero1, float Numero2)
        {
            float result = Numero1 * Numero2; return result;
        }

        
        string Division(float Numero1, float Numero2)
        {
            if (Numero2 != 0)
            {
                string result = (Numero1 + Numero2).ToString();
                return result;
            }
            else
            {
                return "No se puede dividir en 0";
            }
        }
        
    }
}
