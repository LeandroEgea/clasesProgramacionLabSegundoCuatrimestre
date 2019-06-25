using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter writer = new StreamWriter(archivo, false);
            try
            {
                foreach (Patente patente in datos)
                {
                    writer.WriteLine(patente.ToString());
                }
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

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            StreamReader reader = new StreamReader(archivo);
            try
            {
                while(!reader.EndOfStream)
                {
                    try
                    {
                        string codPatente = reader.ReadLine();
                        datos.Enqueue(codPatente.ValidarPatente());
                    }
                    catch (PatenteInvalidaException e)
                    {

                    }
                }
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
