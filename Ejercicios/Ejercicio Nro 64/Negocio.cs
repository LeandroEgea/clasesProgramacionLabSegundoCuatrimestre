using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_Nro_64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1
        {
            get
            {
                return caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return caja2;
            }
        }

        public Negocio(Caja cj1, Caja cj2)
        {
            caja1 = cj1;
            caja2 = cj2;
        }

        public void AsignarCaja()
        {
            //TODO
        }
    }
}
