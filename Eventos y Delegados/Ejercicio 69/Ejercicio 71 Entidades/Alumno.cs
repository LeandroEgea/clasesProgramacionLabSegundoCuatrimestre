using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private int dni;
        private string fotoAlumno;
        private string nombre;

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string RutaDeLaFoto
        {
            get
            {
                return fotoAlumno;
            }
            set
            {
                fotoAlumno = value;
            }
        }

        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            RutaDeLaFoto = ruta;
        }
    }
}
