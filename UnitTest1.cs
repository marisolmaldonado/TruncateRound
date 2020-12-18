using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoundTruncate.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Round()
        {
            //
            var num1 = 12.48675;
            var num2 = 29.18573;
            var esperado = 41.672;
            var numero= 3;
            //

            var calculadora = new Calculadora();
            var resultado = calculadora.Suma(num1, num2);


            Assert.AreEqual(esperado, resultado);
        }

         [TestMethod]
        public void Truncate()
        {
            //
            var num = 64.48675;
            var trunc = 2;
            var esperado =64,48 ;
            //

            var calculadora = new Calculadora();
            var resultado = calculadora.Truncate(num1, num2);


            Assert.AreEqual(esperado, resultado);
        }

    }
}
