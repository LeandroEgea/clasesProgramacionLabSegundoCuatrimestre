using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo(new Punto(4, 4), new Punto(5, 5));
            Console.WriteLine(r.Area());
            Console.WriteLine(r.Perimetro());
            Console.ReadKey();
        }
    }
}
