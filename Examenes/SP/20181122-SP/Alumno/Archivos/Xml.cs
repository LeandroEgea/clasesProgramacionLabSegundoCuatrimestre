using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            try
            {
                ser.Serialize(writer, datos);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
            }
        }

        public void Leer(string archivo, out T datos)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextReader reader = new XmlTextReader(archivo);
            try
            {
                datos = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
