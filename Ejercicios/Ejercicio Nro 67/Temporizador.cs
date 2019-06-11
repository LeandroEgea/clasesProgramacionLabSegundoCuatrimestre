using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_Nro_67
{
    public delegate void encargadoTiempo();
    public class Temporizador
    {
        private int intervalo;

        public event encargadoTiempo EventoTiempo;

        public bool Activo { get; set; }

        public int Intervalo
        {
            get
            {
                return intervalo;
            }
            set
            {
                intervalo = value;
            }
        }

        public Temporizador(int intervalo)
        {
            Activo = false;
            Intervalo = intervalo;
        }

        public void Corriendo()
        {
            Activo = true;
            do
            {
                Thread.Sleep(Intervalo);
                EventoTiempo();
            } while (Activo);
        }
    }
}