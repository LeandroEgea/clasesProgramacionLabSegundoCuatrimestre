using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "Pagina Uno";
            libro[1] = "Pagina Dos";
            libro[2] = "Pagina Tres";
            libro[1] = "Pagina Dos V2";
            libro[4] = "Pagina Cinco";

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(libro[i]);
            }
            Console.ReadKey();
        }
    }
}
