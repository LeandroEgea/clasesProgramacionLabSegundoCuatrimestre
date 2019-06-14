using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoString(string msg);
    
    public class Persona
    {
        private string apellido;
        private string nombre;

        public Persona()
        {

        }

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

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Mostrar()
        {
            return this.Nombre + " " + this.Apellido + "\n";
        }

    }
}
