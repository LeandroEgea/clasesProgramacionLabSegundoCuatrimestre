using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.Nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (Object.ReferenceEquals(c1, null) && Object.ReferenceEquals(c2, null))
                return true;
            else if (!Object.ReferenceEquals(c1, null) && !Object.ReferenceEquals(c2, null))
                return c1.Numero == c2.Numero;
            return false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}