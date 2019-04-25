using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central 
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas 
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            //Llamada aaa = new Llamada(15f, "333", "444");
            //Local llamada = new Local(aaa, 5);
            //Console.WriteLine(llamada.GetType().Name);

            // Las llamadas se irán registrando en la Centralita. 
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando. 
            c.Llamadas.Add(l1);
            c.Llamadas.Add(l2);
            c.Llamadas.Add(l3);
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
