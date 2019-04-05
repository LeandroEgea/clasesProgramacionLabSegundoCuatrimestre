using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Nro_01
{
    static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            if(operador.Equals("/") && num2 == 0)
            {

            }
        }

        private static string ValidarOperador(string operador)
        {
            if (operador.Equals("-") || operador.Equals("/") || operador.Equals("*"))
                return operador;
            return "+";
        }
    }
}
