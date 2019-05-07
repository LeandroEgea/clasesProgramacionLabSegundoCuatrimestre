using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUno = pedirInt("Introduzca Numero", "Error");
            double numeroDos = pedirInt("Introduzca Numero", "Error");
            int operacion = pedirInt("Introduzca Operacion (1: Suma...)", "Error");
            string op = (
                operacion == 1 ? "SUMA" :
                operacion == 2 ? "RESTA" :
                operacion == 3 ? "MULTIPLICACION" :
                operacion == 4 ? "DIVISION" : ""
            );        
            if(op != "")
                Console.WriteLine(Calculadora.Operar(numeroUno, numeroDos, op));
            Console.ReadKey();
        }
        // PEDIR INT
        static int pedirInt(String mensaje, String mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine(mensajeError);
                }
                else
                    return numero;
            }
        }
    }
}