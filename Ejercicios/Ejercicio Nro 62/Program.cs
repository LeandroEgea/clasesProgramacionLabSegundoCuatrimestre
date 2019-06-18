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
            Local l1 = new Local("Bernala", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            LocalDAO.Guardar(l1);
            LocalDAO.Guardar(l3);
            List<Local> locales = LocalDAO.Leer("Bernal");

            foreach (Local local in locales)
            {
                Console.WriteLine(local.Mostrar());
            }
            Console.ReadKey();
        }
    }
}
