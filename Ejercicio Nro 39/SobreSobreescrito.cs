using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_38
{
    public class SobreSobreescrito : Sobreescrito
    {
        protected override string MiPropiedad
        {
            get
            {
                return base.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }
    }
}
