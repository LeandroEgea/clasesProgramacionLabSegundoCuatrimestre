using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        public Alumno()
        {
            this.notaFinal = -1;
        }
        public Alumno(string apellido, int legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
            this.notaFinal = -1;
        }
        public void Estudiar(byte nota1, byte nota2)
        {
            if(nota1 >= 0 && nota1 <=10)
                this.nota1 = nota1;
            if (nota2 >= 0 && nota2 <= 10)
                this.nota2 = nota2;
        }
        public void CalcularFinal()
        {
            if (nota1 >= 4 && nota2 >= 4)
                this.notaFinal = new Random().Next(10);
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append(this.nombre + " ");
            sb.Append(this.apellido);
            sb.Append(Environment.NewLine);
            sb.Append(this.legajo);
            sb.Append(Environment.NewLine);
            sb.Append(stringNotaFinal());
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        private string stringNotaFinal()
        {
            if (this.notaFinal != -1)
                return this.notaFinal.ToString();
            return "Alumno desaprobado";
        }

        public void MostrarNotaFinal()
        {
            Console.WriteLine(this.notaFinal);
        }
    }
}
