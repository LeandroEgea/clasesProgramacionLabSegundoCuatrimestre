using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
                if(equipos.Count > 1)
                {
                    T e1;
                    T e2;
                    do
                    {
                        e1 = DarEquipo();
                        e2 = DarEquipo();
                    } while (e1 == e2);
                    
                    return CalcularPartido(e1, e2);
                }
                return "";
            }
        }

        private T DarEquipo()
        {
            if(equipos.Count > 0)
            {
                Thread.Sleep(500);
                int rnd = new Random().Next(1, (equipos.Count + 1));
                return equipos[rnd - 1];
            }
            return null;
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
            Thread.Sleep(500);
            int r1 = new Random().Next(1, 130);
            Thread.Sleep(500);
            int r2 = new Random().Next(1, 130);

            return String.Format("{0} {1} - {2} {3}", e1.Nombre, r1, r2, e2.Nombre);
        }
    }
}
