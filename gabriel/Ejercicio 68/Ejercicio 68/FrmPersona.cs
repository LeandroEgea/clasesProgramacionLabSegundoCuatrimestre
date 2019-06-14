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

namespace Ejercicio_68
{
    public partial class FrmPersona : Form
    {
        private Persona persona;

        public FrmPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                persona = new Persona();
                persona.Nombre = txtName.Text;
                persona.Apellido = txtSurname.Text;

                btnCrear.Text = "Actualizar";
                EventoForm("Se ha creado la Persona");
            }
            else
            {
                if (!(txtName.Text == persona.Nombre && txtSurname.Text == persona.Apellido))
                {
                    persona.Nombre = txtName.Text;
                    persona.Apellido = txtSurname.Text;
                    EventoForm("Se ha actualizado la Persona");
                }
            }

            EventoForm(persona.Mostrar());

        }

        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private event DelegadoString EventoForm;

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            EventoForm += NotificarCambio;
        }
    }
}
