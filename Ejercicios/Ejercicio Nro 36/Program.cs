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
            AutoF1 kimi = new AutoF1(2, "Ferrari");
            AutoF1 vettel = new AutoF1(1, "Ferrari");
            AutoF1 hamilton = new AutoF1(1, "Mercedes");
            AutoF1 rosberg = new AutoF1(2, "Mercedes");
            bool e;
            Competencia indianapolis = new Competencia(65, 3);

            if (indianapolis + kimi && indianapolis + vettel)
                e = true;
            if (indianapolis + kimi)
                Console.WriteLine(kimi.MostrarDatos());

            Console.WriteLine(hamilton.MostrarDatos());
            if (indianapolis + hamilton)
                Console.WriteLine(hamilton.MostrarDatos());

            if (indianapolis + rosberg)
                Console.WriteLine(rosberg.MostrarDatos());

            Console.WriteLine(indianapolis.MostrarDatos());

            Console.ReadKey();
        }
        //REESCRIBIR EL MAIN PARA PROBAR LO NUEVO
    }
}
