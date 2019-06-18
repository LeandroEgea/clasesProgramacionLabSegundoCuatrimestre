using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69
{
    public partial class FrmTestDelegados : Form
    {
        public event FrmMostrar.DelegadoMostrar EventoActualizar;
        public event FrmMostrar.DelegadoMostrar EventoActualizarFoto;
        private string path;

        public FrmTestDelegados()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EventoActualizar ? .Invoke(txtDatos.Text);
            EventoActualizarFoto ?.Invoke(path);
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
        }
    }
}
