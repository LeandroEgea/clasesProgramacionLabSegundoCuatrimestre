using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_32
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)this.TotalGoles / (float)this.PartidosJugados;
            }
        }

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {

        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.Append("Goles: ");
            sb.Append(this.TotalGoles);
            sb.AppendLine();
            sb.Append("Promedio de Goles: ");
            sb.Append(this.PromedioGoles);
            sb.AppendLine();
            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
