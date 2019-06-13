using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_65_Form
{
    public partial class Form1 : Form
    {
        Centralita centralita;
        Thread hilo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(centralita.GananciasPorLocal.ToString());
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(centralita.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centralita = new Centralita();
            hilo = new Thread(centralita.CrearLlamadas);
            hilo.Start();
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            MessageBox.Show(centralita.GananciasPorProvincial.ToString());
        }
    }
}
