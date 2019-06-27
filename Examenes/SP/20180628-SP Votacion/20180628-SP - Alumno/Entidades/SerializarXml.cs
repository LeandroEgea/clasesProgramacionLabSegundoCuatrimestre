using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXml<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            XmlTextWriter writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            try
            {
                ser.Serialize(writer, objeto);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException("Error al guardar en XML", e);
            }
            finally
            {
                writer.Close();
            }
            return true;
        }

        public T Leer(string rutaArchivo)
        {
            T datos;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextReader reader = new XmlTextReader(rutaArchivo);
            try
            {
                datos = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException("Error al leer des XML", e);
            }
            finally
            {
                reader.Close();
            }
            return datos;
        }
    }
}
