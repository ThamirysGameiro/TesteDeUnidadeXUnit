using Moq;
using TesteDeUnidadeXUnit.API.RegraNegocio;

namespace TesteDeUnidadeXUnit.Testes
{
    public class PedidoTest
    {
        [Fact]
        internal void Processar_Pagamento_Sucesso()
        {
            // Stub
            var pagamentoStub = new Mock<IPagamentoService>();
            pagamentoStub.Setup(pagamentoStub => pagamentoStub.ProcessarPagamento(It.IsAny<decimal>()))
                .Returns(true);

            // Mock
            var logMock = new Mock<ILogService>();

            var processamentoPedido = new ProcessamentoPedido(pagamentoStub.Object, logMock.Object);
            var valor = 100m;

            var result = processamentoPedido.ProcessarPedido(valor);

            Assert.True(result);

            logMock.Verify(l => l.Log("Pagamento processado com sucesso"));

        }

        [Fact]
        internal void Processar_Pagamento_Erro()
        {
            // Stub
            var pagamentoStub = new Mock<IPagamentoService>();
            pagamentoStub.Setup(pagamentoStub => pagamentoStub.ProcessarPagamento(It.IsAny<decimal>()))
                .Returns(false);

            // Mock
            var logMock = new Mock<ILogService>();

            var processamentoPedido = new ProcessamentoPedido(pagamentoStub.Object, logMock.Object);
            var valor = 100m;

            var result = processamentoPedido.ProcessarPedido(valor);

            Assert.False(result);

            logMock.Verify(l => l.Log("Erro ao processar pagamento"));

        }
    }
}
