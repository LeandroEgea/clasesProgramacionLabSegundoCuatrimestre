using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisa
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = (float)1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * cotizRespectoDolar);
        }

        public static explicit operator Peso(Euro e)
        {
            return new Peso((e.cantidad * cotizRespectoDolar) / Peso.GetCotizacion());
        }
    }
}