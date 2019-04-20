using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(8, 2, Colores.Blanco, 6, 1000);
            Console.WriteLine(camion.MostrarDatos());
            Console.ReadKey();
        }
    }
}
