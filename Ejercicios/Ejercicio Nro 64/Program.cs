using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_Nro_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            
            Negocio negocio = new Negocio(caja1, caja2);
            for(int i = 0; i < 20; i++)
            {
                negocio.Clientes.Add("c" + i);
            }
            //Estoy haciendo algo mal

            Thread hiloNegocio = new Thread(negocio.AsignarCaja);
            Thread hiloCaja1 = new Thread(caja1.AtenderClientes);
            hiloCaja1.Name = "Caja1";
            Thread hiloCaja2 = new Thread(caja2.AtenderClientes);
            hiloCaja2.Name = "Caja2";

            hiloNegocio.Start();
            hiloCaja1.Start();
            hiloCaja2.Start();

            Console.ReadKey();

        }
    }
}
