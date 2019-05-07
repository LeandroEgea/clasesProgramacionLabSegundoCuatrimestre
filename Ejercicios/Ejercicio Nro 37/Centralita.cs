using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

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
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
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
                else if(llamada is Provincial && (tipo.Equals(Llamada.TipoLlamada.Todas) || tipo.Equals(Llamada.TipoLlamada.Provincial)))
                {
                    Provincial provincial = (Provincial)llamada;
                    total += provincial.CostoLlamada;
                }
            }
            return total;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Razon Social: " + this.razonSocial);
            sb.Append(" - Local: " + this.GananciasPorLocal);
            sb.Append(" - Provincial: " + this.GananciasPorProvincial);
            sb.Append(" - Total: " + this.GananciasPorTotal);
            foreach(Llamada llamada in listaDeLlamadas)
            {
                sb.Append(llamada.Mostrar());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
