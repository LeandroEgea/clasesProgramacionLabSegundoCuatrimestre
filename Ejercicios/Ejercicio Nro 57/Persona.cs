using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_Nro_57
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;
        private const string PATH = "Persona.txt";

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona persona)
        {
            FileStream fs = new FileStream(PATH, FileMode.Create);
            BinaryFormatter ser = new BinaryFormatter();
            ser.Serialize(fs, persona);
            fs.Close();
        }

        public static Persona Leer()
        {
            FileStream fs = new FileStream(PATH, FileMode.Open);
            BinaryFormatter ser = new BinaryFormatter();
            Persona persona = (Persona)ser.Deserialize(fs);
            fs.Close();
            return persona;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.nombre, this.apellido);
        }
    }
}
