using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_58
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return contenido;
            }
            set
            {
                contenido = value;
            }
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    throw new NotImplementedException();//TODO
                    //throw new ArchivoIncorrectoException("El archivo no es .dat");
                }
            }
            catch (NotImplementedException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
            return true;
        }

        public bool Guardar(string ruta, PuntoDat puntoDat)
        {
            if (File.Exists(ruta))
                return GuardarComo(ruta, puntoDat);
            return false;
        }

        public bool GuardarComo(string ruta, PuntoDat puntoDat)
        {
            FileStream fs = new FileStream(ruta, FileMode.Create);
            BinaryFormatter ser = new BinaryFormatter();
            ser.Serialize(fs, puntoDat);
            fs.Close();
            return true;
        }

        public PuntoDat Leer(string ruta)
        {
            if (File.Exists(ruta))
            {
                FileStream fs = new FileStream(ruta, FileMode.Open);
                BinaryFormatter ser = new BinaryFormatter();
                PuntoDat puntoDat = (PuntoDat)ser.Deserialize(fs);
                fs.Close();
                return puntoDat;
            }
            return null;
        }
        //meter lo del filter
    }
}
