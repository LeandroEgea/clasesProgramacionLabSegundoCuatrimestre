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
using Ejercicio_Nro_58;

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
                switch (openFileDialog.FilterIndex)
                {
                    case 1:
                        mainRichTextBox.Text = new PuntoTxt().Leer(openFileDialog.FileName);
                        break;
                    case 2:
                        PuntoDat puntoDat = new PuntoDat();
                        puntoDat = puntoDat.Leer(openFileDialog.FileName);
                        mainRichTextBox.Text = puntoDat.Contenido;
                        break;
                    //case 3:
                    //    richTextBox1.Text = archivoXml.Leer(ventana.FileName); //REVISAR
                    //    break;
                }
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
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        new PuntoTxt().GuardarComo(path, mainRichTextBox.Text);
                        break;
                    case 2:
                        PuntoDat puntoDat = new PuntoDat();
                        puntoDat.Contenido = mainRichTextBox.Text;
                        puntoDat.GuardarComo(path, puntoDat);
                        break;
                    //case 3:
                    //    archivoXml.GuardarComo(ventana.FileName, richTextBox1.Text);
                    //    break;
                }
            }
        }

        private void guardar()
        {
            switch (Path.GetExtension(path))
            {
                case ".txt":
                    new PuntoTxt().Guardar(path, mainRichTextBox.Text);
                    break;
                case ".dat":
                    PuntoDat puntoDat = new PuntoDat();
                    puntoDat.Contenido = mainRichTextBox.Text;
                    puntoDat.Guardar(path, puntoDat);
                    break;
                    //case ".xml":
                    //    archivoXml.Guardar(nombreArchivo, richTextBox1.Text);
                    //    break;
            }
        }
    }
}