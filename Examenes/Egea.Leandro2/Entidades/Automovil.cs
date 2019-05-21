using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHoraNuevo) : this(patente, color)
        {
            valorHora = valorHoraNuevo;
        }

        public override bool Equals(Object obj)
        {
            return obj is Automovil;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ImprimirTicket());
            sb.Append("Color: ");
            sb.Append(this.color.ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            TimeSpan diferencia = DateTime.Now - base.ingreso;
            int costo = Convert.ToInt32(diferencia.Hours) * valorHora;
            StringBuilder sb = new StringBuilder();
            sb.Append(ConsultarDatos());
            sb.Append("Costo: ");
            sb.Append(costo);
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
