using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_32
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {
        
        }
        public DirectorTecnico(string nombre, DateTime fechaDeNacimiento) : this(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.Append("Nacimiento: ");
            sb.Append(this.fechaDeNacimiento);
            sb.AppendLine();
            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return d1.fechaDeNacimiento == d2.fechaDeNacimiento && d1.Nombre == d2.Nombre;
        }
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
