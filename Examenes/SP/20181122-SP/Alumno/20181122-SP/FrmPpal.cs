using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> hilos;

        public FrmPpal()
        {
            InitializeComponent();
            hilos = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += ProximaPatente;
            vistaPatente2.finExposicion += ProximaPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            //try
            //{
                new Xml<Queue<Patente>>().Leer(@"C:\patentes.xml", out cola);
                cola = cola;
            //}
            //catch (Exception)
            //{
            //    //TODO
            //}
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            //try
            //{
                new Texto().Leer(@"C:\patentes.txt", out cola);
                cola = cola;
            //}
            //catch (Exception)
            //{
            //    //TODO
            //}
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO
            }
            catch (Exception)
            {
                //TODO
            }
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread hilo in hilos)
            {
                if (hilo.IsAlive)
                    hilo.Abort();
            }
        }

        public void ProximaPatente(VistaPatente vp)
        {
            //TODO
        }
    }
}
