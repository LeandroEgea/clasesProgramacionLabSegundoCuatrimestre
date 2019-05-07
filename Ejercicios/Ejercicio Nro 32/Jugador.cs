using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_32
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

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
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DNI: ");
            sb.Append(this.Dni);
            sb.Append(" - Nombre: ");
            sb.Append(this.Nombre);
            sb.Append(" - Goles: ");
            sb.Append(this.TotalGoles);
            sb.Append(" - Promedio de Goles: ");
            sb.Append(this.PromedioGoles);
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
