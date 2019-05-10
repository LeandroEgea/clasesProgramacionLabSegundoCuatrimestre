using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria 
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto productoDeLaLista in this.productos)
                {
                    if (codigo.Equals((Guid)productoDeLaLista))
                        return productoDeLaLista;
                }
                return null;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto productoDeLaLista in comiqueria.productos)
            {
                if (producto.Descripcion.Equals(productoDeLaLista.Descripcion))
                    return true;
            }
            return false;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
                comiqueria.productos.Add(producto);
            return comiqueria;
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();
            foreach (Producto producto in this.productos)
            {
                diccionario.Add((Guid)producto, producto.Descripcion);
            }
            return diccionario;
        }

        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            this.ventas.Sort(CompararVentas);
            foreach(Venta venta in this.ventas)
            {
                sb.AppendLine(venta.ObtenerDescripcionBreve());
            }
            return sb.ToString();
        }

        private int CompararVentas(Venta ventaUno, Venta ventaDos)
        {
            if (ventaUno.Fecha > ventaDos.Fecha)
                return 1;
            else if (ventaUno.Fecha < ventaDos.Fecha)
                return -1;
            return 0;
        }
    }
}
