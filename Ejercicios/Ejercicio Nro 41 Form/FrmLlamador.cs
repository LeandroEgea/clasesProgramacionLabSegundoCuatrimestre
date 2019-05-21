using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_40_Form
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;

        public FrmLlamador()
        {
            InitializeComponent();
        }
        public FrmLlamador(Centralita centralita) : this()
        {
            this.centralita = centralita;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            txtOrigen.Text = "1136955821";
            txtDestino.Enabled = false;
            txtOrigen.Enabled = false;
        }

        private void botonPanel_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Numero Destino")
            {
                txtDestino.Text = "";
            }
            Button button = (Button)sender;
            txtDestino.Text += button.Text;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Llamada llamada;
            if (txtDestino.Text[0] == '#')
            {
                Provincial.Franja franja;
                Enum.TryParse(cmbFranja.SelectedValue.ToString(), out franja);
                llamada = new Provincial(txtOrigen.Text, franja, new Random().Next(1, 50), txtDestino.Text);
            }
            else
            {
                //cmbFranja.Enabled = false;
                llamada = new Local(txtOrigen.Text, new Random().Next(1, 50), txtDestino.Text, (float)new Random().Next(5, 56) / 10);
            }
            if (!ReferenceEquals(llamada, null))
            {
                try
                {
                    this.centralita += llamada;
                    MessageBox.Show("Llamada realiza con exito\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(CentralitaException ce)
                {
                    MessageBox.Show(ce.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtOrigen.Text = "";
            txtDestino.Text = "";
            //cmbFranja.Enabled = true;
            txtOrigen.Text = "1136955821";
            txtDestino.Text = "Numero Destino";
        }
    }
}
