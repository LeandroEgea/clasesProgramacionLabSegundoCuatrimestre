using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_Nro_27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(getNumber());
            }
            mostrarLista(lista);
            mostrarLista(getPositivosDecreciente(lista));
            mostrarLista(getNegativosCreciente(lista));
            Console.ReadKey();
        }

        static int getNumber()
        {
            Random rnd = new Random();
            Thread.Sleep(200);
            return rnd.Next(-100, 100);
        }

        static List<int> getPositivosDecreciente(List<int> lista)
        {
            List<int> retorno = new List<int>();
            foreach (int entero in lista)
            {
                if (entero > 0)
                {
                    retorno.Add(entero);
                }
            }
            retorno.Sort();
            retorno.Reverse();
            return retorno;
        }

        static List<int> getNegativosCreciente(List<int> lista)
        {
            List<int> retorno = new List<int>();
            foreach (int entero in lista)
            {
                if (entero < 0)
                {
                    retorno.Add(entero);
                }
            }
            retorno.Sort();
            return retorno;
        }

        static void mostrarLista(List<int> lista)
        {
            foreach (int entero in lista)
            {
                Console.WriteLine(entero);
            }
            Console.WriteLine("////////");
        }
    }
}
