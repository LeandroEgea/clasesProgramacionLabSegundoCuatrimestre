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
            string retorno = ""; 
            foreach(string palabra in palabras)
            {
                if(!diccionario.ContainsKey(palabra))
                    diccionario.Add(palabra, 1);
                else
                    diccionario[palabra]++;
            }
            //diccionario.




            //KeyValuePair<string, int> first = d;
            ////diccionario.Remove(first.Key);
            //KeyValuePair<string, int> second = diccionario.Max();
            //diccionario.Remove(second.Key);
            //KeyValuePair<string, int> third = diccionario.Max();
            ////retorno += (first.Key + " ");
            //retorno += (second.Key + " ");
            //retorno += (third.Key + " ");
            return retorno;
        }
    }
}
