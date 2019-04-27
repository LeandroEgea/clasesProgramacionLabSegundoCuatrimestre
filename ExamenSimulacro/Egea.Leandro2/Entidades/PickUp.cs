using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHoraNuevo) : this(patente, modelo)
        {
            valorHora = valorHoraNuevo;
        }

        public override bool Equals(Object obj)
        {
            return obj is PickUp;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ImprimirTicket());
            sb.Append("Modelo: ");
            sb.Append(this.modelo);
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
