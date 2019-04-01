using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using objetos;

namespace Ejercicio_Nro_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);
            string dibujo;
            rojo.Pintar(49, out dibujo);
            rojo.Pintar(10, out dibujo);
            Console.ForegroundColor = rojo.GetColor();
            Console.WriteLine(dibujo);

            rojo.Recargar();
            rojo.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);
            Console.ReadKey();
        }
    }
}
