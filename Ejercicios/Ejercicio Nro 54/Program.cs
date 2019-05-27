using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro42
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nombreArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo = ("C:\\src\\" + DateTime.Now.ToString("yyyyMMdd-Hmm") + ".txt");

            try
            {
                MiOtraClase aux = new MiOtraClase();
                aux.MiMetodoInstancia();
            }
            catch (MiException e)
            {
                //e.	MiException será capturada en el Main,
                // mostrando el mensaje de error que esta almacena por pantalla
                // y los mensajes de todas las excepciones almacenadas en sus innerException.

                ArchivoTexto.Guardar(nombreArchivo, e.Message);

                if (!object.ReferenceEquals(e.InnerException, null))
                {
                    Exception ex = e.InnerException;
                    do
                    {
                        ArchivoTexto.Guardar(nombreArchivo, ex.Message);
                        ex = ex.InnerException;
                    } while (!object.ReferenceEquals(ex, null));
                }
            }
            Console.WriteLine(ArchivoTexto.Leer(nombreArchivo));
            Console.ReadKey();
        }
    }
}
