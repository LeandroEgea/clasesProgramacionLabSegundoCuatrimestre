using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public string Apellido 
        {
            get
            {
                return this.apellido;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.Append(this.Nombre);
            sb.AppendLine();
            sb.Append("Apellido: ");
            sb.Append(this.Apellido);
            sb.AppendLine();
            sb.Append("Dni: ");
            sb.Append(this.Dni);
            sb.AppendLine();
            sb.Append("Edad: ");
            sb.Append(this.Edad);
            sb.AppendLine();
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
