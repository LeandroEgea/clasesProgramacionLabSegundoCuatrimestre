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
                return 0; //TODO
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return 0; //TODO
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return 0; //TODO
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return new List<Llamada>(); //TODO
            }
        }

        public Centralita()
        {
            //TODO
        }

        public Centralita(string NombreEmpresa)
        {
            //TODO
        }

        //Calcular Ganancia TODO 

        public string Mostrar()
        {
            return ""; //TODO
        }

        public void OrdenarLlamadas()
        {
            //TODO
        }
    }
}
