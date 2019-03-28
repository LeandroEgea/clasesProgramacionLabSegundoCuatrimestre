using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Schiavi", 1, "Rolando");
            alumno1.Estudiar(3, 5);
            Alumno alumno2 = new Alumno("Perez", 2, "Juan");
            alumno2.Estudiar(8, 6);
            Alumno alumno3 = new Alumno("Juarez", 3, "Rodolfo");
            alumno3.Estudiar(3, 2);
            Console.ReadKey();
        }
    }
}
