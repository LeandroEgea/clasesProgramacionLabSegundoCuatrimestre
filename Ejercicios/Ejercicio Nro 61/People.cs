using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_61
{
    public class People
    {
        private int id;
        private string nombre;
        private string apellido;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public People(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public People(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", nombre, apellido);
        }

    }
}
