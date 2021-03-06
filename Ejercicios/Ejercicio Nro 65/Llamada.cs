﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    [XmlInclude(typeof(Local))]
    [XmlInclude(typeof(Provincial))]
    public abstract class Llamada
    {

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada {get;}

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
            set
            {
                duracion = value;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
            set
            {
                nroDestino = value;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
            set
            {
                nroOrigen = value;
            }
        }

        public Llamada()
        {

        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Duracion: " + this.Duracion);
            sb.AppendLine();
            sb.Append("Origen: " + this.NroOrigen);
            sb.AppendLine();
            sb.Append("Destino: " + this.NroDestino);
            sb.AppendLine();
            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            //return l1.Equals(l2) && l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino;
            return l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            else if (llamada1.Duracion < llamada2.Duracion)
                return -1;
            return 0;
        }
    }
}
