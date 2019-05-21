using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        public string JugarPartido
        {
            get
            {
                //Agarrar 2 equipos //TODO
                //return CalcularPartido(e1, e2);
                return null;
            }
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            foreach(T eq in t.equipos)
            {
                if (e == eq)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if (t != e)
                t.equipos.Add(e);
            return t;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Torneo: {0}", this.nombre));
            sb.AppendLine("Participantes:");
            foreach(T e in this.equipos)
            {
                sb.AppendLine(e.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            return null;//TODO
        }
    }
}
