using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Int32.TryParse(Console.ReadLine(), out a);
            try
            {
                a = 4 / a;
                Console.WriteLine(a);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
