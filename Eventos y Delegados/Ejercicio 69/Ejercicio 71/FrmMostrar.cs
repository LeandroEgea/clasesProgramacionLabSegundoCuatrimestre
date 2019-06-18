using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69
{
    public partial class FrmMostrar : Form
    {
        public delegate void DelegadoMostrar(string dato);
        private Bitmap MyImage;

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string dato)
        {
            lblEtiqueta.Text = dato;
        }

        public void ActualizarFoto(string path)
        {
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            if(File.Exists(path))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                MyImage = new Bitmap(path);
                pictureBox.Image = MyImage;
            }
        }
    }
}
