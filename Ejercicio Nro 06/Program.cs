using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int desde = pedirIntPositivo("Escriba un anio de inicio: ", "Error. Reingrese numero mayor a 0");
            int hasta = pedirIntPositivo("Escriba un anio de final: ", "Error. Reingrese numero mayor a 0");
            Console.WriteLine("Anios bisiestos:");
            for (int i = desde; i <= hasta; i++)
            {
                if (esBisiesto(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        // PEDIR INT POSITIVO
        static int pedirIntPositivo(String mensaje, String mensajeError)
        {
            int numero;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine(mensajeError);
                    error = true;
                }
                else
                    error = false;
            } while (error);
            return numero;
        }
        // ES BISIESTO
        static bool esBisiesto(int anio)
        {
            return (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0);
        }
    }
}