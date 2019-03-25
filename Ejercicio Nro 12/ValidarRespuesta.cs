using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            if (Char.ToLower(c).Equals('s'))
                return true;
            return false;
        }
    }
}
