using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sumaTotal = 0;
            char continuar;
            do
            {
                numero = pedirIntPositivo("Introduzca Numero", "Error");
                sumaTotal += numero;
                continuar = pedirChar("Desea continuar?");
                Console.WriteLine();
            } while (ValidarRespuesta.ValidarS_N(continuar));
            Console.WriteLine("La suma es {0}", sumaTotal);
            Console.ReadKey();
        }
        // PEDIR STRING
        static char pedirChar(String mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadKey().KeyChar;
        }
        // PEDIR INT
        static int pedirIntPositivo(String mensaje, String mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine(mensajeError);
                }
                else
                    return numero;
            }
        }
    }
}