using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.SemDI.LojaOnline
{
    public class LojaOnline
    {
        private readonly PagueSeguroService _pagueSeguroService;
        private readonly PedidoRepository _pedidoRepository;
        private readonly EnvioEmailService _envioEmailService;

        public LojaOnline()
        {
            _pagueSeguroService = new PagueSeguroService();
            _pedidoRepository = new PedidoRepository();
            _envioEmailService = new EnvioEmailService();
        }

        public void ProcessarPedido(Pedido pedido)
        {
            _pagueSeguroService.ProcessarPagamento(pedido.Numero, pedido.CartaoCreditoPagamento, pedido.Valor);
            Logger.Log("Pagamento processado");
            _pedidoRepository.AtualizarPedido(pedido.Numero, "Pago");
            Logger.Log("Pedido atualizado para Pago");
            _envioEmailService.EnviarEmail(pedido.Email, "Seu pedido foi pago", $"Pedido Nº {pedido.Numero} foi pago com sucesso!");
            Logger.Log("Email enviado");
        }
    }
}