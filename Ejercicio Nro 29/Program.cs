using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo aldosivi = new Equipo(2, "Aldosivi");
            Jugador mesi = new Jugador(123, "Lio", 2, 5);
            Jugador deMaria = new Jugador(333, "Fideo", 3, 8);
            Jugador iguain = new Jugador(444, "Pipa", -1, 7);
            bool a;

            if(aldosivi + mesi)
            {
                if (aldosivi + deMaria)
                    Console.WriteLine(deMaria.MostrarDatos());
            }

            if (aldosivi + mesi)
                Console.WriteLine(mesi.MostrarDatos());
            if (aldosivi + iguain)
                Console.WriteLine(iguain.MostrarDatos());

            Console.ReadKey();
        }
    }
}
