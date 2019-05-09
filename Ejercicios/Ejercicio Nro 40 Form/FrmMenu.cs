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
    public partial class FrmMenu : Form
    {
        Centralita centralita = new Centralita();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamdor = new FrmLlamador(centralita);
            frmLlamdor.ShowDialog();
            centralita = frmLlamdor.Centralita;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(centralita, null))
            {
                MessageBox.Show("No se cargo ninguna llamada", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                FrmMostrar frmMostrar = new FrmMostrar(centralita, Llamada.TipoLlamada.Todas);
                frmMostrar.ShowDialog();
            }
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(centralita, null))
            {
                MessageBox.Show("No se cargo ninguna llamada", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                FrmMostrar frmMostrar = new FrmMostrar(centralita, Llamada.TipoLlamada.Local);
                frmMostrar.ShowDialog();
            }
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(centralita, null))
            {
                MessageBox.Show("No se cargo ninguna llamada", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                FrmMostrar frmMostrar = new FrmMostrar(centralita, Llamada.TipoLlamada.Provincial);
                frmMostrar.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
