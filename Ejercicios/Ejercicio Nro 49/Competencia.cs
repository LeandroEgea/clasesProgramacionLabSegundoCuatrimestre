using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        //public enum TipoCompetencia
        //{
        //    F1, 
        //    MotoCross
        //}

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public string Tipo //???
        {
            get
            {
                return typeof(T).Name;
            }
        }

        public T this[int i]
        {
            get
            {
                if (i < competidores.Count)
                {
                    return competidores[i];
                }
                else
                {
                    return null;
                }
            }
        }

        public List<T> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        private Competencia()
        {
            this.competidores = new List<T>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CantidadCompetidores: ");
            sb.Append(this.cantidadCompetidores);
            sb.AppendLine();
            sb.Append("CantidadVueltas: ");
            sb.Append(this.cantidadVueltas);
            sb.AppendLine();
            foreach (T v in this.competidores)
            {
                sb.AppendLine(v.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator ==(Competencia<T> c, T v)
        {
            foreach (T aux in c.competidores)
            {
                if (v == aux)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia<T> c, T v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia<T> c, T v)
        {
            if (c == v || c.competidores.Count >= c.CantidadCompetidores)
                return false;
            c.competidores.Add(v);
            v.EnCompetencia = true;
            v.VueltasRestantes = c.cantidadVueltas;
            v.CantidadCombustible = (short)new Random().Next(15, 100);
            return true;
        }

        public static bool operator -(Competencia<T> c, VehiculoDeCarrera v)
        {
            foreach (T aux in c.competidores)
            {
                if (aux == v)
                {
                    c.competidores.Remove(aux);
                    return true;
                }
            }
            return false;
        }
    }
}