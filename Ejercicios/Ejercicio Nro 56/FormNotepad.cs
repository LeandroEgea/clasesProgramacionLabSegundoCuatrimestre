using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_56
{
    public partial class FormNotepad : Form
    {


        public FormNotepad()
        {
            InitializeComponent();
        }

        private void FormNotepad_Load(object sender, EventArgs e)
        {
            mostrarCantidadCaracteres();
        }

        private void mainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            mostrarCantidadCaracteres();
        }

        private void mostrarCantidadCaracteres()
        {
            caracteresStatusStrip.Text = String.Format("{0} caracteres", mainRichTextBox.Text.Length);
        }

        private void abrirMenuStripItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //TODO me quede aca

                //StreamReader archivo = new StreamReader(RutaDeArchivo);
                //string texto = archivo.ReadToEnd();
                //archivo.Close();
                //return texto;

                //textBox1.Text = openFileDialog.FileName;
            }
        }

        private void guardarComoMenuStripItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.ShowDialog();
        }
    }
}
