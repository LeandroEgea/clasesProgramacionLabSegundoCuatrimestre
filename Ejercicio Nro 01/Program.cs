using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//federicordavila@gmail.com
//FedeDavila1984/utn_prog_ylab_II

namespace Ejercicio_Nro_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean error = false;
            double maximo = 0;
            double minimo = 0;
            double sumaTotal = 0;
            double promedio;
            for (int i = 0; i < 5; i++)
            {
                double numero;
                Console.WriteLine("Escriba un numero");
                if (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    error = true;
                    break;
                }

                if (i == 0 || numero > maximo)
                    maximo = numero;
                if (i == 0 || numero < minimo)
                    minimo = numero;
                sumaTotal = sumaTotal + numero;
            }
            if (!error)
            {
                promedio = sumaTotal / 5;
                Console.WriteLine("El maximo es {0}", string.Format("{0:#,0.00}", maximo));
                Console.WriteLine("El minimo es {0}", string.Format("{0:#,0.00}", minimo));
                Console.WriteLine("El promedio es {0}", string.Format("{0:#,0.00}", promedio));
                Console.ReadKey();
            }
        }
    }
}
