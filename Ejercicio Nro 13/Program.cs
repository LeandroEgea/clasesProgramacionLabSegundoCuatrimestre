using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = "10010101110011101,100";
            double decim = Conversor.BinarioDecimal(bin);
            Console.WriteLine("{0}(2) = {1}(10)", bin, decim);
            decim = 1045;
            bin = Conversor.DecimalBinario(decim);
            Console.WriteLine("{1}(10) = {0}(3)", bin, decim);
            Console.ReadKey();
        }
        // PEDIR BINARIO
        static string pedirBinario(String mensaje, String mensajeError)
        {
            return "";
        }
        // PEDIR DOUBLE
        static double pedirDouble(String mensaje, String mensajeError)
        {
            double numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine(mensajeError);
                }
                else
                    return numero;
            }
        }
    }
}