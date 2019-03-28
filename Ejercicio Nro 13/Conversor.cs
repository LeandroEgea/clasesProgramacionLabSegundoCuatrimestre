using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    class Conversor
    {
        public static string DecimalBinario(double decim)
        {
            int i;
            int num = Int32.Parse(decim.ToString());
            string bin = "";
            for (i = 0; num > 0; i++)
            {
                bin += (num % 2).ToString();
                num = num / 2;
            }
            char[] charArray = bin.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static double BinarioDecimal(string bin)
        {
            double decim = 0;
            if (!bin.Contains(","))
            {
                decim += BinarioEntero(bin);
            }
            else
            {
                string[] bins = bin.Split(',');
                decim += BinarioEntero(bins[0]);
                string decimales = "0," + BinarioEntero(bins[1]).ToString();
                decim += double.Parse(decimales);
            }
            return decim;
        }
        public static int BinarioEntero(string bin)
        {
            char[] array = bin.ToCharArray();
            Array.Reverse(array);
            int suma = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        if (i == 0)
                        {
                            suma += 1;
                        }
                        else
                        {
                            suma += (int)Math.Pow(2, i);
                        }
                    }
                }
            return suma;
        }
    }
}
