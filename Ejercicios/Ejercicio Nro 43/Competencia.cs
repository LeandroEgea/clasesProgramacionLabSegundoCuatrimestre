using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1, 
            MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if (i < competidores.Count)
                {
                    return competidores[i];
                }
                else
                {
                    return null; //new VehiculoDeCarrera(0, "");
                }
            }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CantidadCompetidores: ");
            sb.Append(this.cantidadCompetidores);
            sb.AppendLine();
            sb.Append("CantidadVueltas: ");
            sb.Append(this.cantidadVueltas);
            sb.AppendLine();
            foreach (VehiculoDeCarrera v in this.competidores)
            {
                if (v is AutoF1)// COMO SACAR ESTOS IF ??
                {
                    sb.Append(((AutoF1)v).MostrarDatos());
                }
                else if (v is MotoCross)
                {
                    sb.Append(((MotoCross)v).MostrarDatos());
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            if (v is AutoF1 && c.Tipo == TipoCompetencia.F1)
            {
                foreach (AutoF1 a in c.competidores)
                {
                    if (a == (AutoF1)v)
                    {
                        return true;
                    }
                }
            }
            else if (v is MotoCross && c.Tipo == TipoCompetencia.MotoCross)
            {
                foreach (MotoCross m in c.competidores)
                {
                    if (m == (MotoCross)v)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            if (c == v || c.competidores.Count >= c.CantidadCompetidores ||
                (c.Tipo != TipoCompetencia.F1 && v is AutoF1) ||
                (c.Tipo != TipoCompetencia.MotoCross && v is MotoCross))
                return false;
            c.competidores.Add(v);
            v.EnCompetencia = true;
            v.VueltasRestantes = c.cantidadVueltas;
            v.CantidadCombustible = (short)new Random().Next(15, 100);
            return true;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if (v is AutoF1 && c.Tipo == TipoCompetencia.F1)
            {
                foreach (AutoF1 a in c.competidores)
                {
                    if (a == (AutoF1)v)// esto pincha???
                    {
                        c.competidores.Remove(v);
                        return true;
                    }
                }
            }
            else if (v is MotoCross && c.Tipo == TipoCompetencia.MotoCross)
            {
                foreach (MotoCross m in c.competidores)
                {
                    if (m == (MotoCross)v)
                    {
                        c.competidores.Remove(v);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}