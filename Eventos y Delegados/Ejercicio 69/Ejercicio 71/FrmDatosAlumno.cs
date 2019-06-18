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
using Entidades;

namespace Ejercicio_69
{
    public partial class FrmDatosAlumno : FrmAltaAlumno
    {
        private Bitmap MyImage;

        public FrmDatosAlumno()
        {
            InitializeComponent();
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            TxtNombre = alumno.Nombre;
            TxtApellido = alumno.Apellido;
            TxtDni = alumno.Dni.ToString();

            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            if (File.Exists(alumno.RutaDeLaFoto))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                MyImage = new Bitmap(alumno.RutaDeLaFoto);
                pictureBox.Image = MyImage;
            }
        }
    }
}