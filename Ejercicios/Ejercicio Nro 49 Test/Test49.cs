using System;
using Ejercicio_Nro_30;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio_Nro_46
{
    [TestClass]
    public class Test49
    {
        [TestMethod]
        public void ListaCompetidores_EstaIntanciada_AlCrearCompetencia()
        {
            //Arrange
            Competencia<AutoF1> c = new Competencia<AutoF1>(44, 22);

            //Assert
            Assert.AreNotEqual(c.Competidores, null);
        }

        [TestMethod]
        public void MotoCrossEnCompMotoCross_SeCargaEnCompetidores()
        {
            //Arrange  
            Competencia<MotoCross> c = new Competencia<MotoCross>(33, 20);
            MotoCross v = new MotoCross(2, "Suzuki");
            int cantidadCompetidores;
            //Act 
            bool a = c + v;
            cantidadCompetidores = c.Competidores.Count;
            //Assert
            Assert.AreEqual(1, cantidadCompetidores);
        }

        [TestMethod]
        public void MotoCrossEnCompMotoCross_SeCargaEnCompetidores2()
        {
            //Arrange  
            Competencia<MotoCross> c = new Competencia<MotoCross>(33, 20);
            MotoCross m = new MotoCross(2, "Suzuki");
            MotoCross m2;
            //Act 
            bool a = c + m;
            m2 = c[0];
            //Assert
            if (m != m2)
                Assert.Fail();
            //Assert.AreSame(m, m2);
        }

        [TestMethod]
        public void RestarVehiculo_QueYaNoFigure()
        {
            //Arrange  
            Competencia<MotoCross> c = new Competencia<MotoCross>(33, 20);
            MotoCross m = new MotoCross(2, "Suzuki");
            //Act 
            bool a = c + m;
            a = c - m;
            //Assert
            if (!(c != m))
                Assert.Fail();
            //Assert.AreSame(m, m2);
        }
    }
}
