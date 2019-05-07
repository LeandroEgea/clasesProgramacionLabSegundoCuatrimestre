using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
            this.vueltasRestantes = 0;
        }

        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Escuderia: ");
            sb.Append(this.escuderia);
            sb.Append(" - Numero: ");
            sb.Append(this.numero);
            sb.Append(" - Combustible: ");
            sb.Append(this.cantidadCombustible);
            sb.Append(" - Competencia: ");
            sb.Append(this.enCompetencia);
            sb.Append(" - Vueltas Restantes: ");
            sb.Append(this.vueltasRestantes);
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}