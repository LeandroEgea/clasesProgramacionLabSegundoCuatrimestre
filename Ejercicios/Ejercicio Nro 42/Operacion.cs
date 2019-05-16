using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    public class Operacion
    {
        public int resultado;

        public Operacion(int a, int b, string operacion)
        {
            if(operacion.Equals("/"))
            {
                try
                {
                    Division d = new Division(a, b);
                    this.resultado = d.resultado;
                }
                catch (DivideByZeroException e)
                {
                    throw new Exception("Dividido Entre 0", e);
                }
            }
        }
    }
}
