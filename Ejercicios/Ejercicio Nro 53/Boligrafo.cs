﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return colorTinta;
            }
            set
            {
                colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return tinta;
            }
            set
            {
                tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            UnidadesDeEscritura = unidades;
            Color = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            string textoEscrito = "";
            for(int i=0; i< texto.Length; i++)
            {
                if(UnidadesDeEscritura >= 0.3)
                {
                    UnidadesDeEscritura = (float)(UnidadesDeEscritura - 0.3);
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
            return String.Format("Boligrafo, Color: {0}, Nivel de tinta: {1}", Color, UnidadesDeEscritura);
        }
    }
}
