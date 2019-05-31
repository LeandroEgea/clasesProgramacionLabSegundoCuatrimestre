using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Ice", "Cube");
            Persona.Guardar(p1);
            Persona p2 = Persona.Leer();
            Console.WriteLine(p2.ToString());
            Console.ReadKey();
        }
    }
}
