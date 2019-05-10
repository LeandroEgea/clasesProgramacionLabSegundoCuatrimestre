using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta 
    {
        private static int porcentajeIva;
        private DateTime fecha;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        private void Vender(int cantidad)
        {
            producto.Stock = producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }

        /// <summary>
        /// Calcula el costo total de la venta realizada
        /// </summary>
        /// <param name="precioUnidad">Es el precio por cada unidad del producto</param>
        /// <param name="cantidad">Es la cantidad de unidades del producto</param>
        /// <returns>Devuelve el precio total de la venta</returns>
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double iva = (precioUnidad * cantidad) * (porcentajeIva / 100);
            return precioUnidad * cantidad + iva;
        }

        public string ObtenerDescripcionBreve()
        {
            string precioFinalStr = (String.Format("${0:#,0.00}", this.precioFinal));
            return String.Format("{0} - {1} - {2}", this.Fecha.ToString(), 
                this.producto.Descripcion, precioFinalStr);
        }
    }
}
