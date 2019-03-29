using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Schiavi", 1, "Rolando");
            Alumno alumno2 = new Alumno("Perez", 2, "Juan");
            Alumno alumno3 = new Alumno("Juarez", 3, "Rodolfo");
            //PARCIALES
            alumno1.Estudiar(4, 5);
            alumno2.Estudiar(9, 6);
            alumno3.Estudiar(4, 3);
            //FINAL
            alumno1.CalcularFinal();
            Thread.Sleep(100);
            alumno2.CalcularFinal();
            Thread.Sleep(100);
            alumno3.CalcularFinal();
            //MOSTRAR
            Console.Write(alumno1.Mostrar());
            Console.Write(alumno2.Mostrar());
            Console.Write(alumno3.Mostrar());
            Console.ReadKey();
        }
    }
}
