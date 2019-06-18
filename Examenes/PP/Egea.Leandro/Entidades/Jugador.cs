using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) 
            : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Peso: ");
            sb.Append(this.Peso);
            sb.AppendLine();
            sb.Append("Altura: ");
            sb.Append(this.Altura);
            sb.AppendLine();
            sb.Append("Posicion: ");
            sb.Append(this.Posicion.ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            return (this.Edad <= 40 && this.ValidarEstadoFisico());
        }

        public bool ValidarEstadoFisico()
        {
            double imc = this.Peso / Math.Pow(this.Altura, 2);// ???
            return (imc >= 18.5 && imc <= 25);
        }
    }
}
