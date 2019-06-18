using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                    this.stock = value;
            }
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.Stock = stock;
            this.precio = precio;
        }

        public static explicit operator Guid(Producto producto)
        {
            return producto.codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Descripcion: ");
            sb.AppendLine(this.Descripcion);
            sb.Append("Codigo: ");
            sb.AppendLine(this.codigo.ToString());
            sb.Append("Precio: ");
            sb.AppendLine(String.Format("${0:#,0.00}", this.Precio));
            sb.Append("Stock: ");
            sb.AppendLine(String.Format("{0} unidades", this.Stock.ToString()));
            return sb.ToString();
        }
    }
}
