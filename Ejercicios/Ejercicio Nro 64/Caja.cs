using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_Nro_64
{
    public class Caja
    {
        private List<string> filaDeClientes;

        public List<string> FilaClientes
        {
            get
            {
                return filaDeClientes;
            }
        }

        public Caja()
        {
            filaDeClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            //Thread thread = new Thread(new ParameterizedThreadStart());
            //TODO
        }
    }
}