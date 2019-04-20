using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.totalGoles = 0;
            this.partidosJugados = 0;
        }
        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.totalGoles / (float)this.partidosJugados;
            return this.promedioGoles;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DNI: ");
            sb.Append(this.dni);
            sb.Append(" - Nombre: ");
            sb.Append(this.nombre);
            sb.Append(" - Goles: ");
            sb.Append(this.totalGoles);
            sb.Append(" - Promedio de Goles: ");
            sb.Append(this.GetPromedioGoles());
            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
