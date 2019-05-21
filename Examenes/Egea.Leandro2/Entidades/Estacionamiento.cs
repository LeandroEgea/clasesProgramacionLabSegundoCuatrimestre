using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;


        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.Append(e.nombre);
            sb.AppendLine();
            sb.Append("Espacios: ");
            sb.Append(e.espacioDisponible);
            sb.AppendLine();
            sb.AppendLine();
            foreach (Vehiculo vehiculo in e.vehiculos)
            {
                sb.Append(vehiculo.ConsultarDatos());
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo && vehiculo.Patente.Length == 6 && estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
                estacionamiento.vehiculos.Add(vehiculo);
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in estacionamiento.vehiculos)
            {
                if (v == vehiculo)
                {
                    estacionamiento.vehiculos.Remove(v);
                    return v.ImprimirTicket();
                }     
            }
            return "El vehículo no es parte del estacionamiento";
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo v in estacionamiento.vehiculos)
            {
                if (v == vehiculo)
                    return true;
            }
            return false;
        }

    public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
    }
}
