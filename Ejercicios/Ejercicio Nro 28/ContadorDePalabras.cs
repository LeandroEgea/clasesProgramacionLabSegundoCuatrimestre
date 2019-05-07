using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_28
{
    public partial class ContadorDePalabras : Form
    {
        public ContadorDePalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.lblTopTres.Text = getTopTres(this.rtbInput.Text);
        }

        private string getTopTres(string texto)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string[] palabras = texto.Split(' ');
            foreach(string palabra in palabras)
            {
                if(!diccionario.ContainsKey(palabra))
                    diccionario.Add(palabra, 1);
                else
                    diccionario[palabra]++;
            }

            List<KeyValuePair<string, int>> lista = diccionario.ToList();
            lista.Sort(Comparar);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                sb.Append("\n"+ lista[i].ToString());
            }
            return sb.ToString();
        }

        static int Comparar(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            if (primerElemento.Value > segundoElemento.Value)
                return -1;
            else if (primerElemento.Value < segundoElemento.Value)
                return 1;
            return 0;
        }
    }
}
