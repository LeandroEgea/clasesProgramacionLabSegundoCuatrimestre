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
            bool error = false;
            int numero;
            Console.WriteLine("Escriba un numero");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine("Error. Reingrese numero mayor a 0");
                    error = true;
                }
                else
                    error = false;
            } while (error);
            Console.WriteLine("Centros Numericos");
            if (numero < 2)
            {
                Console.WriteLine("No hay numeros primos.");
            }
            else
            {
                Console.WriteLine("Numeros Primos:");
                for (int i = 2; i <= numero; i++)
                {
                    if (esPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadKey();
        }
        // ES CENTRO NUMERICO
        static bool esCentroNumerico(int numero)
        {
            return true;
        }
    }
}
