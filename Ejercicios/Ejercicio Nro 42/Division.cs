using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    public class Division
    {
        public int resultado;

        public Division(int dividendo, int divisor)
        {
            try
            {
                this.resultado = dividendo / divisor;
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }
    }
}
