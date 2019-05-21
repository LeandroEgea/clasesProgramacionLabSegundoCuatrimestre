using System;
using EjercicioNro42;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EjercicioNro45
{
    [TestClass]
    public class Test42
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void InstanciaMiClaseErrores_DivideByZeroException_Throws()
        {
            //Arrange  
            MiClaseErrores mce = new MiClaseErrores();

            //Assert es manejado en el ExpectedException  
        }

        [TestMethod]
        [ExpectedException(typeof(UnaException))]
        public void InstanciaMiClaseErrores2_UnaException_Throws()
        {
            //Arrange  
            MiClaseErrores mce = new MiClaseErrores(1);

            //Assert es manejado en el ExpectedException  
        }

        [TestMethod]
        [ExpectedException(typeof(MiException))]
        public void MiOtraClase_MiMetodoInstancia_MiException_Throws()
        {
            //Arrange  
            MiOtraClase moc = new MiOtraClase();
            moc.MiMetodoInstancia();

            //Assert es manejado en el ExpectedException  
        }
    }
}

