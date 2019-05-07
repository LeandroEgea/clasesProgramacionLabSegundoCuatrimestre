using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_03
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
                if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                {
                    Console.WriteLine("Error. Reingrese numero mayor a 0");
                    error = true;
                }
                else
                    error = false;
            } while (error);
            if(numero < 2)
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
        static bool esPrimo(int numero)
        {
            if(numero >= 2)
            {
                int contador = 2;
                bool primo = true;
                while ((primo) && (contador != numero))
                {
                    if (numero % contador == 0)
                        primo = false;
                    contador++;
                }
                return primo;
            }
            else
            {
                return false;
            }
            
        }
    }
}
