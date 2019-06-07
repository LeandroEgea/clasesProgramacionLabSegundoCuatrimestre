using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_61
{
    public partial class FormPeople : Form
    {
        public FormPeople()
        {
            InitializeComponent();
        }

        private void FormPeople_Load(object sender, EventArgs e)
        {
            LeerTodo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!NombreVacio())
            {
                PeopleDAO.Guardar(txtNombre.Text, txtApellido.Text);
                LeerTodo();
                Limpiar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            People peopleSelected = (People)listPeople.SelectedItem;
            if (peopleSelected != null)
            {
                PeopleDAO.Borrar(peopleSelected.Id);
                LeerTodo();
            }
            else
            {
                MessageBox.Show("No se ha elegido Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            LeerTodo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            People peopleSelected = (People)listPeople.SelectedItem;
            if(peopleSelected != null)
            {
                if(!NombreVacio())
                {
                    People people = new People(peopleSelected.Id, txtNombre.Text, txtApellido.Text);
                    PeopleDAO.Modificar(people);
                    LeerTodo();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("No se ha elegido Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LeerTodo()
        {
            listPeople.Items.Clear();
            foreach (People p in PeopleDAO.Leer())
            {
                listPeople.Items.Add(p);
            }            
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private bool NombreVacio()
        {
            if(String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("No se ha introducido nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (String.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("No se ha introducido apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }

        private void listPeople_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            People peopleSelected = (People)listPeople.SelectedItem;
            if (peopleSelected != null)
            {
                txtNombre.Text = peopleSelected.Nombre;
                txtApellido.Text = peopleSelected.Apellido;
            }
            else
            {
                MessageBox.Show("No se ha elegido Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
