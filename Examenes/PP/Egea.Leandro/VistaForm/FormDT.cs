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

namespace VistaForm
{
    //mauriciocerizza@gmail.com
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, Convert.ToInt32(numericUpDownEdad.Value),
                Convert.ToInt32(numericUpDownDni.Value), Convert.ToInt32(numericUpDownExperiencia.Value));
            labelMensaje.Text = "Se ha creado el DT!";
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if(dt == null)
            {
                labelMensaje.Text = "Aún no se ha creado el DT del formulario";
            }
            else if(dt.ValidarAptitud())
            {
                labelMensaje.Text = "El DT es apto.";
            }
            else
            {
                labelMensaje.Text = "El DT no es apto.";
            }
        }
    }
}
