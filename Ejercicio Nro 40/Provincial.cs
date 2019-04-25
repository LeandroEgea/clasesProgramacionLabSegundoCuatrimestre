using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float costo = 0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = 0.66f;
                    break;
            }
            return costo * this.duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append(" - Costo: " + this.CostoLlamada);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
