using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_52
{
    public class Lapiz : IAcciones
    {
        //Falta lo de explicita
        private float tamanioMina;

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return tamanioMina;
            }
            set
            {
                tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto) //EscrituraWrapper IAcciones.Escribir(string texto)
        {
            string textoEscrito = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (UnidadesDeEscritura >= 0.1)
                {
                    UnidadesDeEscritura = (float)(UnidadesDeEscritura - 0.1);
                    textoEscrito += texto[i];
                }
            }
            return new EscrituraWrapper(textoEscrito, Color);
        }

        public bool Recargar(int unidades)
        {
            UnidadesDeEscritura = UnidadesDeEscritura + unidades;
            return true;
        }

        public override string ToString()
        {
            return String.Format("Lapiz, Color: {0}, Nivel de tinta: {1}", Color, UnidadesDeEscritura);
        }
    }
}
