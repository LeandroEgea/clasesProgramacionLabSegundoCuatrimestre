using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            //double distanciaEntrePuntos = Math.Abs(Math.Sqrt(Math.Pow((vertice1.GetX() - vertice3.GetY()), 2) + Math.Pow((vertice1.GetX() - vertice3.GetY()), 2)));
        }

        public float Area()
        {
            if(this.area == 0)
            {
                int altura = Math.Abs(vertice1.GetY() - vertice4.GetY());
                int _base = Math.Abs(vertice1.GetX() - vertice2.GetX());
                this.area = altura * _base;
            }
            return this.area;
        }

        public float Perimetro()
        {
            if (this.perimetro == 0)
            {
                int altura = Math.Abs(vertice1.GetY() - vertice4.GetY());
                int _base = Math.Abs(vertice1.GetX() - vertice2.GetX());
                this.perimetro = (altura + _base) * 2;
            }
            return this.perimetro;
        }

        public static string Mostrar(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append(rectangulo.);
            //TODO
            return "";
        }
    }
}
