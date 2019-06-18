using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        //ESTO SE GUARDA EN Ejercicio59\bin\Debug
        private const string PATH_TXT = "Provincial.xml";

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;
        private string rutaDeArchivo;

        public Franja FranjaHoraria
        {
            get
            {
                return franjaHoraria;
            }
            set
            {
                franjaHoraria = value;
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

        private Provincial() : base()
        {
            this.RutaDeArchivo = PATH_TXT;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.RutaDeArchivo = PATH_TXT;
            this.franjaHoraria = miFranja;
        }

        public bool Guardar()
        {
            XmlTextWriter writer = new XmlTextWriter(RutaDeArchivo, Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(Provincial));
            ser.Serialize(writer, this);
            writer.Close();
            return true;
        }

        public Provincial Leer()
        {
            Provincial provincial;
            XmlTextReader reader = new XmlTextReader(RutaDeArchivo);
            XmlSerializer ser = new XmlSerializer(typeof(Provincial));
            Object obj = ser.Deserialize(reader);
            if (obj is Provincial)
                provincial = (Provincial)obj;
            else
                throw new InvalidCastException();
            //Provincial provincial = (Provincial)ser.Deserialize(reader);
            reader.Close();
            return provincial;
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

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Franja: " + this.franjaHoraria.ToString());
            sb.AppendLine();
            sb.Append("Costo: " + this.CostoLlamada);
            sb.AppendLine();
            return sb.ToString();
        }

        public override bool Equals(Object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
