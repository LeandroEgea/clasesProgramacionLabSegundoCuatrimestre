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

namespace Ejercicio_69
{
    public delegate void DelegadoAlumno(Alumno Alumno);

    public partial class FrmAltaAlumno : Form
    {
        public event DelegadoAlumno EventoAlumno;
        private Alumno alumno; 

        protected string TxtNombre
        {
            set
            {
                txtNombre.Text = value;
            }
        }

        protected string TxtApellido
        {
            set
            {
                txtApellido.Text = value;
            }
        }

        protected string TxtDni
        {
            set
            {
                txtDni.Text = value;
            }
        }

        public FrmAltaAlumno()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dni = 0;
            Int32.TryParse(txtDni.Text, out dni);
            alumno = new Alumno(txtNombre.Text, txtApellido.Text, dni, txtFoto.Text);
            EventoAlumno ?.Invoke(alumno);
        }

        private void lblFoto_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFoto.Text = openFileDialog.FileName;
            }
        }
    }
}
