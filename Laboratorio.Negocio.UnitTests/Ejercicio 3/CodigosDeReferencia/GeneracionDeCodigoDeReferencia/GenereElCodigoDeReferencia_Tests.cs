using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorio.Negocio.Ejercicio3.CodigosDeReferencia;

namespace Laboratorio.Negocio.UnitTests.Ejercicio3
{
    [TestClass()]
    public class GenereElCodigoDeReferencia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DateTime laFecha;
        private short elCliente;
        private short elSistema;

        private string elConsecutivo;
        private string elDigito;

        [TestInitialize()]
        public void Inicialice()
        {
            laFecha = new DateTime(2000, 11, 11);
            elCliente = 333;
            elSistema = 22;
            elConsecutivo = "888888888888";
            elDigito = "7";
        }

        [TestMethod()]
        public void GenereElCodigoDeReferencia_GeneraDosVerificadores_TruncaAUnDigito()
        {
            elResultadoEsperado = "20001111333228888888888887";

            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElCodigoDeReferencia(laFecha, elCliente, elSistema, elConsecutivo, elDigito);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElCodigoDeReferencia_ClienteTieneMenosDigitos_PrecedeConCero()
        {
            elResultadoEsperado = "20001111033228888888888887";

            elCliente = 33;
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElCodigoDeReferencia(laFecha, elCliente, elSistema, elConsecutivo, elDigito);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElCodigoDeReferencia_SistemaTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001111333028888888888887";

            elSistema = 2;
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElCodigoDeReferencia(laFecha, elCliente, elSistema, elConsecutivo, elDigito);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElCodigoDeReferencia_MesTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20000111333228888888888887";

            laFecha = new DateTime(2000, 1, 11);
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElCodigoDeReferencia(laFecha, elCliente, elSistema, elConsecutivo, elDigito);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElCodigoDeReferencia_DiaTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001101333228888888888887";

            laFecha = new DateTime(2000, 11, 1);
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElCodigoDeReferencia(laFecha, elCliente, elSistema, elConsecutivo, elDigito);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElCodigoDeReferencia_ConsecutivoTieneMenosDigitos_PrecedeConCeros()
        {
            elResultadoEsperado = "20001111333220000000000047";

            elConsecutivo = "4";
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElCodigoDeReferencia(laFecha, elCliente, elSistema, elConsecutivo, elDigito);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}