using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisa
{
    class Peso
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Peso()
        {
            cotizRespectoDolar = (float)0.02608922515;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, float cotizacion)
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

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() * Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return new Euro((p.GetCantidad() * Peso.GetCotizacion()) / Euro.GetCotizacion());
        }

        public static Peso operator +(Peso p1, Peso p2)
        {
            return new Peso(p1.GetCantidad() + p2.GetCantidad());
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() + d.GetCantidad() / Peso.GetCotizacion());
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() + e.GetCantidad() * Euro.GetCotizacion() / Peso.GetCotizacion());
        }

        public static Peso operator -(Peso p1, Peso p2)
        {
            return p1 + new Peso(-p2.GetCantidad());
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return p + new Dolar(-d.GetCantidad());
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return p + new Euro(-e.GetCantidad());
        }
    }
}