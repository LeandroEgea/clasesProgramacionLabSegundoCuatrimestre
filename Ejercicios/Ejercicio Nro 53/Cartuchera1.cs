using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_52
{
    public class Cartuchera1
    {
        public List<IAcciones> utiles;

        public Cartuchera1()
        {
            utiles = new List<IAcciones>();
        }

        public bool ProbarElementos()
        {
            bool utilGastado = false;
            foreach (IAcciones util in utiles)
            {
                if(util.UnidadesDeEscritura >= 1)
                {
                    util.UnidadesDeEscritura -= 1;
                }
                else
                {
                    util.UnidadesDeEscritura = 0;
                    utilGastado = true;
                    try
                    {
                        util.Recargar(10);
                    }
                    catch(NotImplementedException)
                    {

                    }
                }
            }
            return !utilGastado;
        }
    }
}
