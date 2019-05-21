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
            //try
            //{
            //    throw new CompetenciaNoDisponibleExcepcion("A", "Program", "Main", new Exception("B", new Exception("C", new Exception("D"))));
            //}
            //catch(CompetenciaNoDisponibleExcepcion e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //Console.ReadKey();

            AutoF1 kimi = new AutoF1(2, "Ferrari", 190);
            AutoF1 vettel = new AutoF1(1, "Ferrari", 200);
            MotoCross rossi = new MotoCross(1, "Susuki", 500);
            MotoCross lorenzo = new MotoCross(2, "Susuki", 510);
            bool b;

            Competencia indianapolis = new Competencia(65, 3, Competencia.TipoCompetencia.MotoCross);

            try
            {
                b = indianapolis + kimi;
            }
            catch(CompetenciaNoDisponibleExcepcion e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
