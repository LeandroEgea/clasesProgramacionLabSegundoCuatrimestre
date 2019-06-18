using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_73
{
    public static class MiExtension
    {
        public static int CantidadDeSignosDePuntuacion(this string cadena)
        {
            int total = cadena.Split('.').Length - 1;
            total += cadena.Split(',').Length - 1;
            total += cadena.Split(';').Length - 1;
            return total;
        }
    }
}

