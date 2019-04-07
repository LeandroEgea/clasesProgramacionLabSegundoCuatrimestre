using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Nro_01
{
    class Numero
    {
        private double numero;

        public Numero() : this(0)
        {
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.SetNumero(numero);
        }

        private void SetNumero(string numero)
        {
            this.numero = ValidarNumero(numero);
        }

        private double ValidarNumero(string numero)
        {
            double doubleNumero;
            try
            {
                double.TryParse(numero, out doubleNumero);
                return doubleNumero;
            }
            catch
            {
                return 0;
            }
        }

        public string BinarioDecimal(string binario)
        {
            return "";//TODO
        }

        public string DecimalBinario(double numero)
        {
            return "";//TODO
        }

        public string DecimalBinario(string numero)
        {
            return "";//TODO
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;//TODO dividir entre 0
        }
    }
}
