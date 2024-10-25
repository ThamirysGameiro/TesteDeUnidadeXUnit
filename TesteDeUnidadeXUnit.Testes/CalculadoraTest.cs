using TesteDeUnidadeXUnit.API.RegraNegocio;

namespace TesteDeUnidadeXUnit.Testes
{
    public class CalculadoraTest
    {      

        [Fact]
        public void Somar_Dois_Numeros()
        {
            var calculadora = new Calculadora();

            var result = calculadora.Somar(5, 10);

            Assert.Equal(15, result);
        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(1, 1, 1)]
        public void Dividir_Dois_Numeros(double x, double y, double resultadoEsperado)
        {
            var calculadora = new Calculadora();

            var result = calculadora.Dividir(x, y);

            Assert.Equal(resultadoEsperado, result);
        }

        [Fact]
        public void Subtrair_Dois_Numeros()
        {
            var calculadora = new Calculadora();

            var result = calculadora.Subtrair(5, 10);

            Assert.Equal(-5, result);
        }

        [Fact]
        public void Multiplicar_Dois_Numeros()
        {
            var calculadora = new Calculadora();

            var result = calculadora.Multiplicar(5, 10);

            Assert.Equal(50, result);
        }


        [Fact]
        public void Meu_Teste()
        {

        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        public void Meu_Teste_Com_Parametro(double x, double y)
        {
            // meu teste aqui
        }

        [Fact(Skip = "Esse teste só tem que ser considerado amanhã")]
        public void Meu_Teste_Ignorado()
        {
            // meu teste aqui
        }
    }
}