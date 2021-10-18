using IoC.And.DI.ComDI.LojaOnline.Notificacoes;
using IoC.And.DI.ComInjecaoDependencias.Factory.Pagamentos;
using IoC.And.DI.ComDI.LojaOnline.Logs;
using IoC.And.DI.ComDI.LojaOnline.Pedido;

namespace IoC.And.DI.ComInjecaoDependencias.ViaMetodo
{
    public interface ILojaOnline
    {
        void ProcessarPedido(SemDI.LojaOnline.Pedido pedido, IMetodoDePagamento metodoDePagamento);
    }

    public class LojaOnline : ILojaOnline
    {
        private readonly Logger logger;
        private readonly AtualizarPedido atualizarPedido;
        private readonly Notificacao notificacao;

        public LojaOnline(
            Logger logger,
            AtualizarPedido atualizarPedido,
            Notificacao notificacao)
        {
            this.logger = logger;
            this.atualizarPedido = atualizarPedido;
            this.notificacao = notificacao;
        }

        // Vantagens: Não é necessário instanciar uma nova loja para cada método de pagamento
        public void ProcessarPedido(SemDI.LojaOnline.Pedido pedido, IMetodoDePagamento metodoDePagamento)
        {
            metodoDePagamento.ProcessarPagamento(pedido.Numero, pedido.CartaoCreditoPagamento, pedido.Valor);
            logger.Log("Pagamento processado");
            atualizarPedido.Atualizar(pedido.Numero, "Pago");
            logger.Log("Pedido atualizado para Pago");
            notificacao.Notificar(pedido.Email, "Seu pedido foi pago", $"Pedido Nº {pedido.Numero} foi pago com sucesso!");
            logger.Log("Email enviado");
        }
    }
}