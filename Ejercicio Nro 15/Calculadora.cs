using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    class Calculadora
    {
        public static double Operar(double valorUno, double valorDos, String operacion)
        {
            switch(operacion)
            {
                case "SUMA":
                    return Suma(valorUno, valorDos);
                case "RESTA":
                    return Resta(valorUno, valorDos);
                case "MULTIPLICACION":
                    return Multiplicacion(valorUno, valorDos);
                case "DIVISION":
                    return Division(valorUno, valorDos);
                default:
                    return 0;
            }
        }
        private static bool Validar(double divisor)
        {
            return divisor == 0 ? false : true;
        }
        private static double Suma(double sumandoUno, double sumandoDos)
        {
            return sumandoUno + sumandoDos;
        }
        private static double Resta(double minuendo, double sustraendo)
        {
            return minuendo - sustraendo;
        }
        private static double Multiplicacion(double factorUno, double factorDos)
        {
            return factorUno * factorDos;
        }
        private static double Division(double dividendo, double divisor)
        {
            if(Validar(divisor))
                return dividendo / divisor;
            return 0;
        }
    }
}
