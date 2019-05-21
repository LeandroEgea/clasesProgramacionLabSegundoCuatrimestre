using System;
using CentralitaHerencia;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio_Nro_44
{
    [TestClass]
    public class TestCentralita
    {
        [TestMethod]
        public void ListaDeLLamadas_EstaIntanciada_AlCrearCentralita()
        {
            //Arrange
            Centralita centralita = new Centralita("Call Center");

            //Assert
            Assert.AreNotEqual(centralita.Llamadas, null);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LLamadasLocalesMismoOrigenYDestino_CentralitaException_Throws()
        {
            //Arrange  
            Centralita centralita = new Centralita("Call Center");
            Llamada a = new Local("123", 4, "456", 10);
            Llamada b = new Local("123", 2, "456", 9);
            //Act  
            centralita += a;
            centralita += b;
            //Assert es manejado en el ExpectedException  
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LLamadasMismoOrigenYDestinoLocalYProvincial_CentralitaException_Throws()
        {
            //Arrange  
            Centralita centralita = new Centralita("Call Center");
            Llamada a = new Provincial("123", Provincial.Franja.Franja_1, 6, "456");
            Llamada b = new Local("123", 4, "456", 10);
            //Act  
            centralita += a;
            centralita += b;
            //Assert es manejado en el ExpectedException  
        }

        [TestMethod]
        public void LocalesYProvinciales_ComparacionesTipoObjeto()
        {
            //Arrange  
            Llamada l1 = new Local("123", 4, "456", 10);
            Llamada l2 = new Local("112", 2, "666", 9);
            Llamada p1 = new Provincial("123", Provincial.Franja.Franja_1, 6, "456");
            Llamada p2 = new Provincial("123", Provincial.Franja.Franja_2, 13, "999");

            //Assert
            Assert.AreEqual(l1, l2);
            Assert.AreNotEqual(l1, p1);
            Assert.AreNotEqual(l1, p2);
            Assert.AreNotEqual(l2, p1);
            Assert.AreNotEqual(l2, p2);

            Assert.AreEqual(p1, p2);
            Assert.AreNotEqual(p1, l1);
            Assert.AreNotEqual(p1, l2);
            Assert.AreNotEqual(p2, l1);
            Assert.AreNotEqual(p2, l2);
        }

    }
}
