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

namespace Ejercicio_Nro_67
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();

            Temporizador t = new Temporizador(1000);
            t.EventoTiempo += T_evento;
            Thread hilo = new Thread(t.Corriendo);
            hilo.Start();
        }

        private void T_evento()
        {
            if (lblHora.InvokeRequired)
            {
                encargadoTiempo del = new encargadoTiempo(T_evento);
                Invoke(del);
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString();
            }
        }
    }
}