using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisa
{
    class Dolar
    {
        private double cantidad;

        static Dolar()
        {

        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad / Peso.GetCotizacion());
        }
    }
}