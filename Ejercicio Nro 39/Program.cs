using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº39 Guía 2017";
            SobreSobreescrito sobrecarga = new SobreSobreescrito();
            Console.WriteLine(sobrecarga.ToString());
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals("a"));
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con Sobreescrito: ");
            Console.WriteLine(sobrecarga.Equals(new SobreSobreescrito()));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.MiMetodo());
            Console.ReadKey();
        }
    }
}
