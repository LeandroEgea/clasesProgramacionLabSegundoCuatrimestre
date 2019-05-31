using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_58
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if (validaExistencia && File.Exists(ruta))
            {
                throw new FileNotFoundException();
            }
            return true;
        }
    }
}
