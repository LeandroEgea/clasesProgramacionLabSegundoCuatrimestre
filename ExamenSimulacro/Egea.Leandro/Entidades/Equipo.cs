using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }  
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.Append(e.Nombre);
            sb.AppendLine();
            sb.AppendLine();
            if (e.directorTecnico != null)
            {
                sb.Append(e.directorTecnico.Mostrar());
            }
            else
            {
                sb.Append("Sin DT Asignado");
            }
            foreach (Jugador jugador in e.jugadores)
            {
                sb.AppendLine();
                sb.Append(jugador.Mostrar());
            }
            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            return e.jugadores.Contains(j);
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e != j && e.jugadores.Count < cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool tieneDT = e.directorTecnico != null;
            bool tieneMaximojugadores = e.jugadores.Count == cantidadMaximaJugadores;
            int arqueros = 0;
            int defensores = 0;
            int centrales = 0;
            int delanteros = 0;
            foreach (Jugador jugador in e.jugadores)
            {
                switch(jugador.Posicion)
                {
                    case Posicion.Arquero:
                        arqueros++;
                        break;
                    case Posicion.Defensor:
                        defensores++;
                        break;
                    case Posicion.Central:
                        centrales++;
                        break;
                    case Posicion.Delantero:
                        delanteros++;
                        break;
                }
            }
            return (tieneDT && arqueros == 1 && defensores > 0 && centrales > 0 && delanteros > 0  && tieneMaximojugadores);
        }
    }
}
