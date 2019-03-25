using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = pedirIntPositivo("Escriba un numero para visualizar una piramide: ", "Error. Reingrese numero mayor a 0");
            int asteriscos = 1;
            int espacios = cantidad - 1;
            string str;
            for (int i = 0; i < cantidad; i++)
            {
                str = "";
                str += stringMismoCaracter(espacios, " ");
                str += stringMismoCaracter(asteriscos, "*");
                str += stringMismoCaracter(espacios, " ");
                Console.WriteLine(str);
                espacios -= 1;
                asteriscos += 2;
            }
            Console.ReadKey();
        }
        // PEDIR INT
        static int pedirIntPositivo(String mensaje, String mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    Console.WriteLine(mensajeError);
                else
                    return numero;
            }
        }
        // STRING CON MISMO CARACTER
        static string stringMismoCaracter(int longitud, string caracter)
        {
            string str = "";
            for (int i = 0; i < longitud; i++)
            {
                str += caracter;
            }
            return str;
        }
    }
}