using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CantidadCompetidores: ");
            sb.Append(this.cantidadCompetidores);
            sb.Append(" - CantidadVueltas: ");
            sb.Append(this.cantidadVueltas);
            foreach (AutoF1 auto in this.competidores)
                sb.Append(auto.MostrarDatos());
            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c == a || c.competidores.Count >= c.cantidadCompetidores)
                return false;
            c.competidores.Add(a);
            a.SetEnCompetencia(true);
            a.SetVueltasRestantes(c.cantidadVueltas);
            a.SetCantidadCombustible((short)new Random().Next(15, 100));
            return true;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}