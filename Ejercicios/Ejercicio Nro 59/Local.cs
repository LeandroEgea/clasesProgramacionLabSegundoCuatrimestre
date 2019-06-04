﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        //ESTO SE GUARDA EN Ejercicio59\bin\Debug
        private const string PATH_TXT = "Local.xml";

        protected float costo;
        private string rutaDeArchivo;

        public float Costo
        {
            get
            {
                return CalcularCosto();
            }
            set
            {

            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return rutaDeArchivo;
            }
            set
            {
                rutaDeArchivo = value;
            }
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private Local() : base()
        {

        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.RutaDeArchivo = PATH_TXT;
            this.costo = costo;
        }

        public bool Guardar()
        {
            XmlTextWriter writer = new XmlTextWriter(RutaDeArchivo, Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(Local));
            ser.Serialize(writer, this);
            writer.Close();
            return true;
        }

        public Local Leer()
        {
            XmlTextReader reader = new XmlTextReader(RutaDeArchivo);
            XmlSerializer ser = new XmlSerializer(typeof(Local));
            Local local = (Local)ser.Deserialize(reader); // TODO meter la exception
            reader.Close();
            return local;
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
