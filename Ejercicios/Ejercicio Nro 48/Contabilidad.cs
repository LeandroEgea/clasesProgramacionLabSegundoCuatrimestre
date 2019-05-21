using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_48
{
    public class Contabilidad<T, U> 
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T e)
        {
            c.egresos.Add(e);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U i)
        {
            c.ingresos.Add(i);
            return c;
        }
    }
}
