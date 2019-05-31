using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        private IAcciones iAcciones;

        ConsoleColor IAcciones.Color
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

        float IAcciones.UnidadesDeEscritura
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
            iAcciones = this;
            iAcciones.UnidadesDeEscritura = unidades;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            iAcciones = this;
            string textoEscrito = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (iAcciones.UnidadesDeEscritura >= 0.1)
                {
                    iAcciones.UnidadesDeEscritura = (float)(iAcciones.UnidadesDeEscritura - 0.1);
                    textoEscrito += texto[i];
                }
            }
            return new EscrituraWrapper(textoEscrito, iAcciones.Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            iAcciones = this;
            iAcciones.UnidadesDeEscritura = iAcciones.UnidadesDeEscritura + unidades;
            return true;
        }

        public override string ToString()
        {
            iAcciones = this;
            return String.Format("Lapiz, Color: {0}, Nivel de tinta: {1}", iAcciones.Color, iAcciones.UnidadesDeEscritura);
        }
    }
}
