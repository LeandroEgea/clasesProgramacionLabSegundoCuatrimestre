using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                if (clientes.Count > 0)
                {
                    return clientes.Dequeue();
                }
                return null;
            }
            set
            {
                bool a = this + value;// ???
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente cliente in n.clientes)
            {
                if (c == cliente)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c)
                return false;
            n.clientes.Enqueue(c);
            return true;
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
    }
}