using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosPerfectos = 0;
            int numero = 1;
            Console.WriteLine("Numeros Perfectos");
            do
            {
                if (esNumeroPerfecto(numero))
                {
                    Console.WriteLine(numero);
                    numerosPerfectos++;
                }
                numero++;
            } while (numerosPerfectos < 4);
            Console.ReadKey();
        }
        // ES NUMERO PERFECTO
        static bool esNumeroPerfecto(int numero)
        {
            int suma = 0;
            for (int i = 1; i<numero; i++)
            {
                if (esDivisor(numero, i))
                    suma += i;
            }
            return (suma == numero);
        }
        // ES DIVISOR
        static bool esDivisor(int numero, int divisor)
        {
            return (numero % divisor == 0);
        }
    }
}
