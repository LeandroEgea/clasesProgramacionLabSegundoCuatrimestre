using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_Nro_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for(int i = 0; i < 20; i++)
            {
                array[i] = getNumber();
            }
            mostrarArray(array);
            mostrarArray(getPositivosDecreciente(array));
            mostrarArray(getNegativosCreciente(array));
            Console.ReadKey();
        }

        static int getNumber()
        {
            Random rnd = new Random();
            Thread.Sleep(200);
            return rnd.Next(-100, 100);
        }

        static int[] getPositivosDecreciente(int[] array)
        {
            int[] retorno = new int[20];
            int j = 0;
            foreach(int entero in array)
            {
                if(entero > 0)
                {
                    retorno[j] = entero;
                    j++;
                }
            }
            Array.Sort(retorno);
            Array.Reverse(retorno);
            return retorno;
        }

        static int[] getNegativosCreciente(int[] array)
        {
            int[] retorno = new int[20];
            int j = 0;
            foreach (int entero in array)
            {
                if (entero < 0)
                {
                    retorno[j] = entero;
                    j++;
                }
            }
            Array.Sort(retorno);
            return retorno;
        }

        static void mostrarArray(int[] array)
        {
            foreach(int entero in array)
            {
                if(entero != 0)
                Console.WriteLine(entero);
            }
            Console.WriteLine("////////");
        }
    }
}
