using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_32
{
    public class Persona
    {
        private int dni;
        private string nombre;

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
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

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(int dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DNI: ");
            sb.Append(this.Dni);
            sb.AppendLine();
            sb.Append("Nombre: ");
            sb.Append(this.Nombre);
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
