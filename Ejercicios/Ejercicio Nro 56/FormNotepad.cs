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

namespace Ejercicio_Nro_56
{
    public partial class FormNotepad : Form
    {
        private string path;

        public FormNotepad()
        {
            InitializeComponent();
            saveFileDialog.InitialDirectory = @"C:\";
            openFileDialog.InitialDirectory = @"C:\";
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                StreamReader archivo = new StreamReader(path);
                mainRichTextBox.Text = archivo.ReadToEnd();
                archivo.Close();
            }
        }

        private void GuardarMenuStripItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
                guardar();
            else
                guardarComo();
        }

        private void guardarComoMenuStripItem_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        private void guardarComo()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                guardar();
            }
        }

        private void guardar()
        {
            StreamWriter archivo = new StreamWriter(path);
            archivo.Write(mainRichTextBox.Text);
            archivo.Close();
        }
    }
}
