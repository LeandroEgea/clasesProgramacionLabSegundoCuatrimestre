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
                    if (Path.GetExtension(ruta) == ".txt")
                        return true;
                    else
                        throw new ArchivoIncorrectoException("El archivo no es .txt");
                }
            }
            catch (ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
            return true;
        }

        public bool Guardar(string ruta, string texto)
        {
            try
            {
                if (base.ValidarArchivo(ruta, true))
                    return GuardarComo(ruta, texto);
            }
            catch (ArchivoIncorrectoException)
            {

            }
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
            try
            {
                if (base.ValidarArchivo(ruta, true))
                {
                    StreamReader archivo = new StreamReader(ruta);
                    string texto = archivo.ReadToEnd();
                    archivo.Close();
                    return texto;
                }
            }
            catch (ArchivoIncorrectoException)
            {

            }
            return null;
        }
    }
}
