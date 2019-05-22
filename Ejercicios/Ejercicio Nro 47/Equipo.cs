using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre.Equals(e2.nombre) && e2.fechaCreacion.Equals(e2.fechaCreacion);
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            return String.Format("{0} fundado el {1}", this.nombre, this.fechaCreacion.ToString("dd/MM/yyyy"));
        }
    }
}
