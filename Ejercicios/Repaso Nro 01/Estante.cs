using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Nro_01
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ubicacion:" + e.ubicacionEstante);
            sb.AppendLine();
            sb.Append("Productos:");
            sb.AppendLine();
            foreach (Producto p in e.GetProductos())
            {
                if(!Object.ReferenceEquals(p,null))
                {
                    sb.Append(Producto.MostrarProducto(p));
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            return e.GetProductos().Contains<Producto>(p);
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            int i = 0;
            if(e != p)
            {
                foreach(Producto producto in e.GetProductos())
                {
                    if(Object.ReferenceEquals(producto, null))
                    {
                        e.GetProductos()[i] = p;
                        return true;
                    }
                    i++;
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int i = 0;
            if (e == p)
            {
                foreach (Producto producto in e.GetProductos())
                {
                    if (Object.ReferenceEquals(producto, p))
                    {
                        e.GetProductos()[i] = null;
                        break;
                    }
                    i++;
                }
            }
            return e;
        }
    }
}
