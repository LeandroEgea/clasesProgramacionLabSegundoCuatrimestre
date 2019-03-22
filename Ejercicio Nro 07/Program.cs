using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicion_Nro_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = pedirMes();
            int dia = pedirDia(mes);
            int anio = pedirIntPositivo("Escriba su anio de nacimiento: ", "Error. Reingrese numero mayor a 0");
            
            int dias = ((TimeSpan)(DateTime.Now - new DateTime(anio, mes, dia))).Days;
            if(dias >= 0)
            {
                Console.WriteLine("Dias desde el nacimiento:");
                Console.WriteLine(dias);
            }
            else
                Console.WriteLine("Hola ser del futuro");
            Console.ReadKey();
        }
        // PEDIR MES Y DIA
        static int pedirMes()
        {
            return pedirIntEnIntervalo(1, 12, "Escriba su mes de nacimiento: ", "Error");
        }
        static int pedirDia(int mes)
        {
            int[] mesesDeTreinta = { 4, 6, 9, 11 };
            int diasEnElMes;
            if (mes == 2)
                diasEnElMes = 28;
            else if (mesesDeTreinta.Contains(mes))
                diasEnElMes = 30;
            else
                diasEnElMes = 31;
            return pedirIntEnIntervalo(1, diasEnElMes, "Escriba su dia de nacimiento: ", "Error");
        }

        // PEDIR INT
        static int pedirIntPositivo(String mensaje, String mensajeError)
        {
            int numero;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine(mensajeError);
                    error = true;
                }
                else
                    error = false;
            } while (error);
            return numero;
        }
        static int pedirIntEnIntervalo(int desde, int hasta, String mensaje, String mensajeError)
        {
            int numero;
            bool error;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero < desde || numero > hasta)
                {
                    Console.WriteLine(mensajeError);
                    error = true;
                }
                else
                    error = false;
            } while (error);
            return numero;
        }

    }
}