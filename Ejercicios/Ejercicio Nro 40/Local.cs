﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Costo: " + this.CostoLlamada);
            sb.AppendLine();
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
