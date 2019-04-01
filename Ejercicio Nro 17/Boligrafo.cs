using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos
{
    class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;

        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            if (this.tinta + tinta <= 0)
                this.tinta = 0;
            else if (this.tinta + tinta >= cantidadTintaMaxima)
                this.tinta = cantidadTintaMaxima;
            else
                this.tinta += tinta;
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";
            int gastoRealizado = gasto < tinta ? gasto : tinta;
            SetTinta((short) - gastoRealizado);
            for (int i = 0; i<gastoRealizado; i++)
            {
                dibujo += "*";
            }
            return gasto <= tinta ? true : false;
        }
    }
}
