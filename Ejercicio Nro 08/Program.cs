using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = pedirString("Ingrese el nombre del empleado: ", "Error.");
            double valorHora = pedirDoublePositivo("Ingrese el valor hora del empleado: ", "Error. Reingrese numero mayor a 0");
            int antiguedad = pedirIntPositivoOCero("Ingrese la antiguedad del empleado(en anios): ", "Error.");
            int horas = pedirIntPositivoOCero("Ingrese las horas trabajadas en el mes: ", "Error.");

            double sueldoBruto = (valorHora * horas + antiguedad * 150);
            double sueldoNeto = sueldoBruto * 0.87;

            Console.WriteLine(nombre);
            Console.WriteLine(valorHora);
            Console.WriteLine(antiguedad);
            Console.WriteLine(horas);
            Console.WriteLine(sueldoBruto);
            Console.WriteLine(sueldoNeto);
            Console.ReadKey();
        }
        // PEDIR STRING
        static string pedirString(String mensaje, String mensajeError)
        {
            string input;
            Console.WriteLine(mensaje);
            while (true)
            {
                input = Console.ReadLine();
                if (input.Length > 0)
                    return input;
                else
                    Console.WriteLine(mensajeError);
            }
        }
        // PEDIR DOUBLE
        static double pedirDoublePositivo(String mensaje, String mensajeError)
        {
            double numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    Console.WriteLine(mensajeError);
                else
                    return numero;
            }
        }
        // PEDIR INT
        static int pedirIntPositivo(String mensaje, String mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    Console.WriteLine(mensajeError);
                else
                    return numero;
            }
        }
        static int pedirIntPositivoOCero(String mensaje, String mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                    Console.WriteLine(mensajeError);
                else
                    return numero;
            } 
        }
        static int pedirIntEnIntervalo(int desde, int hasta, String mensaje, String mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero < desde || numero > hasta)
                    Console.WriteLine(mensajeError);
                else
                    return numero;
            }
        }

    }
}