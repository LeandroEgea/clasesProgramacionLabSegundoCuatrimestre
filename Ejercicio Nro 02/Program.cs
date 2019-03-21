using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicion_Nro_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error;
            int numero;
            Console.WriteLine("Escriba un numero");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                {
                    Console.WriteLine("Error. Reingrese numero");
                    error = true;
                }
                else
                    error = false;
            } while (error);         

            Console.WriteLine("El cuadrado es {0}", string.Format("{0:#,0.00}", Math.Pow(numero, 2)));
            Console.WriteLine("El cubo es {0}", string.Format("{0:#,0.00}", Math.Pow(numero, 3)));
            Console.ReadKey();
        }
    }
}
