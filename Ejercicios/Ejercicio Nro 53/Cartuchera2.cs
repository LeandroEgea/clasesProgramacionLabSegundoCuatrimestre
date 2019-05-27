using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_52
{
    public class Cartuchera2
    {
        public List<Lapiz> lapices;
        public List<Boligrafo> boligrafos;

        public Cartuchera2()
        {
            lapices = new List<Lapiz>();
            boligrafos = new List<Boligrafo>();
        }

        public bool ProbarElementos()
        {
            bool utilGastado = false;
            foreach (Lapiz lapiz in lapices)
            {
                if(lapiz.UnidadesDeEscritura >= 1)
                {
                    lapiz.UnidadesDeEscritura -= 1;
                }
                else
                {
                    lapiz.UnidadesDeEscritura = 0;
                    utilGastado = true;
                }
            }
            foreach (Boligrafo boligrafo in boligrafos)
            {
                if (boligrafo.UnidadesDeEscritura >= 1)
                {
                    boligrafo.UnidadesDeEscritura -= 1;
                }
                else
                {
                    boligrafo.UnidadesDeEscritura = 0;
                    utilGastado = true;
                    boligrafo.Recargar(10);
                }
            }
            return !utilGastado;
        }
    }
}
