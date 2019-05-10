using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto producto;
        private Comiqueria comiqueria;

        public VentasForm(Producto producto, Comiqueria comiqueria)
        {
            InitializeComponent();
            this.producto = producto;
            this.comiqueria = comiqueria;
            this.lblDescripcion.Text = producto.Descripcion;
            actualizarPrecio();
        }

        private void actualizarPrecio(object sender, EventArgs e)
        {
            actualizarPrecio();
        }

        private void actualizarPrecio()
        {
            double precio = Venta.CalcularPrecioFinal(producto.Precio, getIntFromNumericUpDown());
            this.lblPrecioFinal.Text = (String.Format("${0:#,0.00}", precio));
        }

        private int getIntFromNumericUpDown()
        {
            return Decimal.ToInt32(this.numericUpDownCantidad.Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (getIntFromNumericUpDown() <= producto.Stock)
            {
                comiqueria.Vender(producto, getIntFromNumericUpDown());
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Supero el stock, debe disminuir la cantidad de unidades"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
