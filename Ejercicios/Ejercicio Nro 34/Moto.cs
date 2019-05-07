using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_34
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrica;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrica) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrica = cilindrica;
        }

    }
}
