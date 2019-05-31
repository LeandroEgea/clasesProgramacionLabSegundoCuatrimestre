using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_58
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    throw new NotImplementedException();//TODO
                    //throw new ArchivoIncorrectoException("El archivo no es .txt");
                }
            }
            catch(NotImplementedException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
            return true;
        }

        public bool Guardar(string ruta, string texto)
        {
            if (File.Exists(ruta))
                return GuardarComo(ruta, texto);
            return false;
        }

        public bool GuardarComo(string ruta, string texto)
        {
            StreamWriter archivo = new StreamWriter(ruta);
            archivo.Write(texto);
            archivo.Close();
            return true;
        }

        public string Leer(string ruta)
        {
            if (File.Exists(ruta))
            {
                StreamReader archivo = new StreamReader(ruta);
                string texto = archivo.ReadToEnd();
                archivo.Close();
                return texto;
            }
            return null;
        }
    }
}
