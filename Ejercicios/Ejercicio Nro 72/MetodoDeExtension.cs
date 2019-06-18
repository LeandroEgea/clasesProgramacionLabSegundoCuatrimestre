using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_72
{
    public static class MiExtension
    {
        public static int CantidadDeDigitos(this long numeroLong)
        {
            return Convert.ToInt32(Math.Floor(Math.Log10(numeroLong) + 1));
        }
    }
}

