using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_73
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cadena = "Hola que tal"; // 0
            string cadena = "Hola . Que .Tal ;,,.aa"; //6
            Console.WriteLine(cadena.CantidadDeSignosDePuntuacion().ToString());
            Console.ReadKey();
        }
    }
}
