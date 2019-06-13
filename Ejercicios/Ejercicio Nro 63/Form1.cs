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

namespace Ejercicio_Nro_63
{
    public partial class Form1 : Form
    {
        Thread hilo;

        public Form1()
        {
            InitializeComponent();
        }

        //------------------1------------------ //TODO
        //Se queda trabado

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    AsignarHora();
        //}

        //private void Form1_Activated(object sender, EventArgs e)
        //{
        //    //while (true)
        //    //{
        //    //    Thread.Sleep(1000);
        //    //    AsignarHora();
        //    //}
        //}

        //private void AsignarHora()
        //{
        //    lblHora.Text = DateTime.Now.ToString();
        //}

        //------------------2------------------

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    AsignarHora();
        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    AsignarHora();
        //}

        //this.timer.Tick += new System.EventHandler(this.timer_Tick); //Descomentar esta linea del designer

        //private void AsignarHora()
        //{
        //    lblHora.Text = DateTime.Now.ToString();
        //}

        //------------------3------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
            hilo = new Thread(AsignarHora);
            hilo.Start();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void AsignarHora()
        {
            while (true)
            {
                if (lblHora.InvokeRequired)
                {
                    lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblHora.Text = DateTime.Now.ToString();
                    });
                }
                else
                {
                    lblHora.Text = DateTime.Now.ToString();
                }
                Thread.Sleep(1000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hilo.Abort();
        }
    }
}
