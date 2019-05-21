using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    public class CompetenciaNoDisponibleExcepcion : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }

        public CompetenciaNoDisponibleExcepcion(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {

        }

        public CompetenciaNoDisponibleExcepcion(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}:", this.NombreMetodo, this.NombreClase);
            sb.AppendLine();
            sb.AppendLine(this.Message);

            Exception e = base.InnerException;
            while (!object.ReferenceEquals(e, null))
            {
                sb.Append(e.Message);
                sb.Append("\t");
                e = e.InnerException;
            }
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
