using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Nro_01
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(p.marca + "/");
            sb.Append(p.codigoDeBarra + "/");
            sb.Append(p.precio);
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.GetMarca().Equals(p2.GetMarca()) && ((string)p1).Equals((string)p2));
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return (p.GetMarca().Equals(marca));
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
