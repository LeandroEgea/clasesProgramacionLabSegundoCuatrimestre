﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        //------------------1------------------ //TODO
        private void Form1_Load(object sender, EventArgs e)
        {
            AsignarHora();
        }

        private void AsignarHora()
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            while(true)
            {
                Thread.Sleep(1000);
                AsignarHora();
            }
        }

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

        //------------------2------------------//TODO
    }
}