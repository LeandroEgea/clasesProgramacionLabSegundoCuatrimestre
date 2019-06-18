using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }


        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) 
            : base(nombre, apellido, edad, dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }

        /// <summary>
        /// Muestra los datos de un Director Tecnico
        /// </summary>
        /// <returns>Un string con todos los datos</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Experiencia: ");
            sb.Append(this.AñosExperiencia);
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Valida que el director tecnico sea menor a 65 anios y tengo 2 o mas anios de experiencia
        /// </summary>
        /// <returns>True si cumple las condiciones, si no false</returns>
        public override bool ValidarAptitud()
        {
            return(this.AñosExperiencia >= 2 && this.Edad < 65);
        }
    }
}
