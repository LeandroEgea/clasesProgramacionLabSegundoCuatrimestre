using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Divisa;

namespace Ejercicio_Nro_23
{
    public partial class ConversorDisvisasVista : Form
    {
        public ConversorDisvisasVista()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(this.txtEuro.Text, out cantidad);
            Euro euro = new Euro(cantidad);
            this.txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
            this.txtEuroAPeso.Text = ((Peso)euro).GetCantidad().ToString();
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(this.txtDolar.Text, out cantidad);
            Dolar dolar = new Dolar(cantidad);
            this.txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
            this.txtDolarAPeso.Text = ((Peso)dolar).GetCantidad().ToString();
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(this.txtPeso.Text, out cantidad);
            Peso peso = new Peso(cantidad);
            this.txtPesoAEuro.Text = ((Euro)peso).GetCantidad().ToString();
            this.txtPesoADolar.Text = ((Dolar)peso).GetCantidad().ToString();
        }
    }
}
