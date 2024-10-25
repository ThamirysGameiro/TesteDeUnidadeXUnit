namespace TesteDeUnidadeXUnit.API.RegraNegocio
{
    public interface IPagamentoService
    {
        bool ProcessarPagamento(decimal valor);
    }

    public interface ILogService
    {
        void Log(string mensagem);
    }

    public class ProcessamentoPedido
    {
        private readonly IPagamentoService _pagamentoService;
        private readonly ILogService _log;
        public ProcessamentoPedido(IPagamentoService pagamentoService, ILogService log)
        {
            _pagamentoService = pagamentoService;
            _log = log;
        }

        public bool ProcessarPedido(decimal valor) 
        {
            if(_pagamentoService.ProcessarPagamento(valor))
            {
                _log.Log("Pagamento processado com sucesso");
                return true;
            }
            else 
            {
                _log.Log("Erro ao processar pagamento");
                return false;
            }
        }
    }
}
