using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class Guardado
    {
        [TestMethod]
        public void Test_XML()
        {
            //Arrange
            Xml<Patente> xml = new Xml<Patente>();
            Patente patentePreGuardado;
            Patente patentePosGuardado;

            //Act
            patentePreGuardado = new Patente("AAA123", Patente.Tipo.Vieja);
            xml.Guardar(@"C:\zzz\testpatente.xml", patentePreGuardado);
            xml.Leer(@"C:\zzz\testpatente.xml", out patentePosGuardado);

            //Assert
            Assert.AreEqual("AAA123", patentePosGuardado.CodigoPatente);
            Assert.AreEqual(Patente.Tipo.Vieja, patentePosGuardado.TipoCodigo);
        }

        [TestMethod]
        public void Test_TXT()
        {
            //Arrange
            Texto txt = new Texto();
            Queue<Patente> colaPreGuardado;
            Queue<Patente> colaPosGuardado;
            Patente patentePosGuardado;

            //Act
            colaPreGuardado = new Queue<Patente>();
            colaPreGuardado.Enqueue(new Patente("AAA123", Patente.Tipo.Vieja));
            txt.Guardar(@"C:\zzz\testpatente.txt", colaPreGuardado);
            txt.Leer(@"C:\zzz\testpatente.txt", out colaPosGuardado);
            patentePosGuardado = colaPosGuardado.Dequeue();

            //Assert
            Assert.AreEqual("AAA123", patentePosGuardado.CodigoPatente);
            Assert.AreEqual(Patente.Tipo.Vieja, patentePosGuardado.TipoCodigo);
        }

        //NO ESTA PROBADO EL DE SQL

        [TestMethod]
        public void Test_SQL()
        {
            //Arrange
            Sql sql = new Sql();
            Queue<Patente> colaPreGuardado;
            Queue<Patente> colaPosGuardado;
            Patente patentePosGuardado;

            //Act
            colaPreGuardado = new Queue<Patente>();
            colaPreGuardado.Enqueue(new Patente("AAA123", Patente.Tipo.Vieja));
            sql.Guardar("Patentes", colaPreGuardado);
            sql.Leer("Patentes", out colaPosGuardado);
            patentePosGuardado = colaPosGuardado.Dequeue();

            //Assert
            Assert.AreEqual("AAA123", patentePosGuardado.CodigoPatente);
            Assert.AreEqual(Patente.Tipo.Vieja, patentePosGuardado.TipoCodigo);
        }
    }
}
