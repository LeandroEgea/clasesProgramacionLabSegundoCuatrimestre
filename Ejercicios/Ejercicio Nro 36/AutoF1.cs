using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.Append(" - Horses: ");
            sb.Append(this.CaballosDeFuerza);
            sb.AppendLine();
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.CaballosDeFuerza == a2.CaballosDeFuerza);// ???
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}