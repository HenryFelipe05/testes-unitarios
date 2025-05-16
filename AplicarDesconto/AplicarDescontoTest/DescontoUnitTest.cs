using _08_AplicarDesconto;

namespace AplicarDescontoTest
{
    [TestClass]
    public sealed class DescontoUnitTest
    {
        private Desconto _desconto;

        [TestInitialize]
        public void setup() 
        {
            _desconto = new Desconto();
        }

        [TestMethod]
        [DataRow(380, true)]
        [DataRow(320, false)]
        [DataRow(2400, true)]
        [DataRow(210, false)]
        [DataRow(2560.50f, true)]
        [DataRow(120.50f, false)]
        public void recebeValor(float valor, bool resultadoEsperado)
        {
           bool resultadoObtido = _desconto.recebeDesconto(valor);

           Assert.AreEqual(resultadoEsperado, resultadoObtido);
        }

        [TestMethod]
        [DataRow(125.00f, 0.0f)]
        [DataRow(850.00f, 0.5f)]
        [DataRow(1468.93f, 1.0f)]
        [DataRow(4655.45f, 2.0f)]
        [DataRow(8974.60f, 3.0f)]
        public void retornaPercentualDesconto(float valor, float resultadoEsperado) 
        {
            float resultadoObtido = _desconto.percentualDesconto(valor);

            Assert.AreEqual(resultadoEsperado, (resultadoObtido * 100));
        }

        [TestMethod]
        [DataRow(125.00f, 0.00f)]
        [DataRow(850.00f, 4.25f)]
        [DataRow(1468.93f, 14.69f)]
        [DataRow(4655.45f, 93.11f)]
        [DataRow(8974.60f, 269.24f)]
        public void retornaValorDesconto(float valor, float resultadoEsperado)
        {
            float resultadoObtido = _desconto.valorDesconto(valor);

            Assert.AreEqual(resultadoEsperado, resultadoObtido, 2);
        }

        [TestMethod]
        [DataRow(125.00f, 125.00f)]
        [DataRow(850.00f, 845.75f)]
        [DataRow(1468.93f, 1454.24f)]
        [DataRow(4655.45f, 4562.34f)]
        [DataRow(8974.60f, 8705.42f)]
        public void retornaTotalCompra(float valor, float resultadoEsperado)
        {
            float resultadoObtido = _desconto.totalCompra(valor);

            Assert.AreEqual(resultadoEsperado, resultadoObtido, 2);
        }
    }
}
