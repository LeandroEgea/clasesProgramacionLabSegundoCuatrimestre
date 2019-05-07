using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_05
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
            Console.WriteLine("Centros Numericos:");
            for (int i = 1; i <= numero; i++)
            {
                if (esCentroNumerico(i))
                {

                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        // ES CENTRO NUMERICO
        static bool esCentroNumerico(int numero)
        {
            int sumaMenores = sumaNumerosMenores(numero);
            return sumaNumerosMayoresQueEsIgualA(numero, sumaMenores);
        }
        // SUMA MENORES
        static int sumaNumerosMenores(int numero)
        {
            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                suma += i;
            }
            return suma;
        }
        // SUMA MAYORES
        static bool sumaNumerosMayoresQueEsIgualA(int numero, int numeroAIgualar)
        {
            int suma = 0;
            int mayor = numero + 1;
            do
            {
                suma += mayor;
                if (suma == numeroAIgualar)
                {
                    return true;
                }
                mayor++;
            }while (suma < numeroAIgualar) ;
            return false;
        }
    }
}