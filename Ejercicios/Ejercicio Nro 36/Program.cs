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
            AutoF1 kimi = new AutoF1(2, "Ferrari", 190);
            AutoF1 vettel = new AutoF1(1, "Ferrari", 200);
            AutoF1 hamilton = new AutoF1(1, "Mercedes", 150);
            AutoF1 rosberg = new AutoF1(2, "Mercedes");
            MotoCross rossi = new MotoCross(1, "Susuki", 500);
            MotoCross lorenzo = new MotoCross(2, "Susuki", 510);
            MotoCross pedrosa = new MotoCross(2, "Honda", 510);
            MotoCross capirossi = new MotoCross(3, "Honda", 500);
            MotoCross capirossi2 = new MotoCross(3, "Honda", 510);
            bool b;

            Competencia indianapolis = new Competencia(65, 3, Competencia.TipoCompetencia.MotoCross);

            if (indianapolis + rossi && indianapolis + lorenzo)
                Console.WriteLine(lorenzo.MostrarDatos());

            if (indianapolis + rossi)
                Console.WriteLine(rossi.MostrarDatos());

            if (indianapolis + kimi)
                Console.WriteLine(kimi.MostrarDatos());

            if (indianapolis + capirossi)
                Console.WriteLine(capirossi.MostrarDatos());

            if (indianapolis + capirossi2)
                Console.WriteLine(capirossi2.MostrarDatos());

            if (indianapolis - capirossi)
                Console.WriteLine("OUT");

            if (indianapolis + capirossi2)
                Console.WriteLine("IN");

            Console.WriteLine(indianapolis.Tipo);
            MotoCross m1 = (MotoCross)indianapolis[1];
            //MotoCross m2 = (MotoCross)indianapolis[3];
            VehiculoDeCarrera m3 = indianapolis[2];

            Console.WriteLine(m1.MostrarDatos());
            //Console.WriteLine(m2.MostrarDatos());
            Console.WriteLine(m3.MostrarDatos());

            //Console.WriteLine(indianapolis.MostrarDatos());

            Console.ReadKey();
        }
    }
}
