using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" - Escuderia: ");
            sb.Append(this.escuderia);
            sb.AppendLine();
            sb.Append(" - Numero: ");
            sb.Append(this.numero);
            sb.AppendLine();
            sb.Append(" - Combustible: ");
            sb.Append(this.cantidadCombustible);
            sb.AppendLine();
            sb.Append(" - Competencia: ");
            sb.Append(this.enCompetencia);
            sb.AppendLine();
            sb.Append(" - Vueltas Restantes: ");
            sb.Append(this.vueltasRestantes);
            sb.AppendLine();
            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia);
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}