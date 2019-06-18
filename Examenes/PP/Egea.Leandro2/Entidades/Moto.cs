using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHoraNuevo) : this(patente, cilindrada, ruedas)
        {
            valorHora = valorHoraNuevo;
        }

        public override bool Equals(Object obj)
        {
            return obj is Moto;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ImprimirTicket());
            sb.Append("Ruedas: ");
            sb.Append(this.ruedas);
            sb.AppendLine();
            sb.Append("Cilindrada: ");
            sb.Append(this.cilindrada);
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
