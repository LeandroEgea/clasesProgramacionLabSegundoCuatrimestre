﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        //ESTO SE GUARDA EN Ejercicio59\bin\Debug
        private const string PATH_TXT = "LogCentralita2.txt";

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        private string rutaDeArchivo;

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

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.RutaDeArchivo = PATH_TXT;
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public bool Guardar()
        {
            StreamWriter archivo = new StreamWriter(RutaDeArchivo, true);
            if (File.Exists(RutaDeArchivo))
            {
                archivo.WriteLine(DateTime.Now.ToString("dddd dd MMMM yyyy H:mm") + " - Se realizo una llamada");
                archivo.Close();
                return true;
            }
            return false;
        }

        public string Leer()
        {
            if (File.Exists(RutaDeArchivo))
            {
                StreamReader archivo = new StreamReader(RutaDeArchivo);
                string texto = archivo.ReadToEnd();
                archivo.Close();
                return texto;
            }
            return "";
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float total = 0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if(llamada is Local && (tipo.Equals(Llamada.TipoLlamada.Todas) || tipo.Equals(Llamada.TipoLlamada.Local)))
                {
                    Local local = (Local)llamada;
                    total += local.CostoLlamada;
                }
                if(llamada is Provincial && (tipo.Equals(Llamada.TipoLlamada.Todas) || tipo.Equals(Llamada.TipoLlamada.Provincial)))
                {
                    Provincial provincial = (Provincial)llamada;
                    total += provincial.CostoLlamada;
                }
            }
            return total;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Razon Social: " + this.razonSocial);
            sb.AppendLine();
            sb.Append("Local: " + this.GananciasPorLocal);
            sb.AppendLine();
            sb.Append("Provincial: " + this.GananciasPorProvincial);
            sb.AppendLine();
            sb.Append("Total: " + this.GananciasPorTotal);
            sb.AppendLine();
            foreach (Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine();
                sb.Append(llamada.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada l in c.Llamadas)
            {
                if(l == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c == nuevaLlamada)
            {
                throw new CentralitaException("La llamada ya existe en el sistema", typeof(Centralita).Name, "+ Operator");
            }     
            else 
            {
                c.AgregarLlamada(nuevaLlamada);
                if(!c.Guardar())
                {
                    throw new CentralitaException("FallaLogException", typeof(Centralita).Name, "+ Operator");
                }
            }
            return c;
        }
    }
}
