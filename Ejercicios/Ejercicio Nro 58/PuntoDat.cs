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
        public PuntoDat()
        {

        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".dat")
                        return true;
                    else
                        throw new ArchivoIncorrectoException("El archivo no es .dat");
                }
            }
            catch (ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
            return true;
        }

        public bool Guardar(string ruta, PuntoDat puntoDat)
        {
            try
            {
                if (base.ValidarArchivo(ruta, true))
                    return GuardarComo(ruta, puntoDat);
            }
            catch (ArchivoIncorrectoException)
            {

            }
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
            try
            {
                if (base.ValidarArchivo(ruta, true))
                {
                    FileStream fs = new FileStream(ruta, FileMode.Open);
                    BinaryFormatter ser = new BinaryFormatter();
                    PuntoDat puntoDat = (PuntoDat)ser.Deserialize(fs);
                    fs.Close();
                    return puntoDat;
                }
            }
            catch (ArchivoIncorrectoException)
            {

            }
            return null;
        }
    }
}