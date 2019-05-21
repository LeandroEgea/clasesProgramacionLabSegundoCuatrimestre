using System;
using Ejercicio_Nro_30;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio_Nro_46
{
    [TestClass]
    public class Test43
    {
        [TestMethod]
        public void ListaCompetidores_EstaIntanciada_AlCrearCompetencia()
        {
            //Arrange
            Competencia c = new Competencia(44, 22, Competencia.TipoCompetencia.F1);

            //Assert
            Assert.AreNotEqual(c.Competidores, null);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleExcepcion))]
        public void AutoF1EnCompMotoCross_CompetenciaNoDisponibleExcepcion_Throws()
        {
            //Arrange  
            Competencia c = new Competencia(33, 20, Competencia.TipoCompetencia.MotoCross);
            AutoF1 v = new AutoF1(2, "Ferrari");
            //Act 
            bool a = c + v;
            //Assert es manejado en el ExpectedException  
        }

        [TestMethod]
        public void MotoCrossEnCompMotoCross_SeCargaEnCompetidores()
        {
            //Arrange  
            Competencia c = new Competencia(33, 20, Competencia.TipoCompetencia.MotoCross);
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
            Competencia c = new Competencia(33, 20, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(2, "Suzuki");
            MotoCross m2;
            //Act 
            bool a = c + m;
            m2 = (MotoCross)c[0];
            //Assert
            if (m != m2)
                Assert.Fail();
            //Assert.AreSame(m, m2);
        }

        [TestMethod]
        public void RestarVehiculo_QueYaNoFigure()
        {
            //Arrange  
            Competencia c = new Competencia(33, 20, Competencia.TipoCompetencia.MotoCross);
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
