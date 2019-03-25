using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = pedirIntPositivo("Escriba un numero para visualizar un triangulo ", "Error. Reingrese numero mayor a 0");
            string str = "*";
            for (int i=0; i<cantidad; i++) 
            {
                if(i!=0)
                {
                    str += "**";
                }
                Console.WriteLine(str);
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
                {
                    Console.WriteLine(mensajeError);
                }
                else
                    return numero;
            }
        }
    }
}