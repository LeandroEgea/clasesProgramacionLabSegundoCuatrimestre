using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_Nro_31
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        public int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            if (cli == null)
                return false;
            Thread.Sleep(1000);
            return true;
        }
    }
}
