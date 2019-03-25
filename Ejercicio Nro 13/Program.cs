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
            int numero;
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