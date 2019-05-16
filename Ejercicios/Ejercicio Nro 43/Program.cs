using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CompetenciaNoDisponibleExcepcion("A", "Program", "Main", new Exception("B", new Exception("C", new Exception("D"))));
            }
            catch(CompetenciaNoDisponibleExcepcion e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}
