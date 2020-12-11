using Matematica.negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SumaDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 3.7;
            var esperado = 21.7;

            var miCalculadora = new Calculadora();

            var resultado = miCalculadora.Sumar(primerNumero,segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void SumarComplejos()
        {
            var primerNumeroComplejo = new Complejo(3,2);
            var segundoNumeroComplejo = new Complejo(1.5,6);
            var esperadoComplejo = new Complejo(4.5,8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.SumarComplejos(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejo.X, resultado.X);
            Assert.AreEqual(esperadoComplejo.Y, resultado.Y);
        }
    }
}
