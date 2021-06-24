using IoC.And.DI.ComDI.LojaOnline.Logs;
using IoC.And.DI.ComDI.LojaOnline.Notificacoes;
using IoC.And.DI.ComDI.LojaOnline.Pagamentos;
using IoC.And.DI.ComDI.LojaOnline.Pedido;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ComDI.LojaOnline
{
    public class LojaOnline
    {
        private readonly Logger logger;
        private readonly MetodoDePagamento metodoDePagamento;
        private readonly AtualizarPedido atualizarPedido;
        private readonly Notificacao notificacao;

        public LojaOnline(
            Logger logger,
            MetodoDePagamento metodoDePagamento,
            AtualizarPedido atualizarPedido,
            Notificacao notificacao)
        {
            this.logger = logger;
            this.metodoDePagamento = metodoDePagamento;
            this.atualizarPedido = atualizarPedido;
            this.notificacao = notificacao;
        }

        public void ProcessarPedido(SemDI.LojaOnline.Pedido pedido)
        {
            metodoDePagamento.ProcessarPagamento(pedido.Numero, pedido.CartaoCreditoPagamento, pedido.Valor);
            logger.Log("Pagamento processado");
            atualizarPedido.Atualizar(pedido.Numero, "Pago");
            logger.Log("Pedido atualizado para Pago");
            notificacao.Notificar(pedido.Email, "Seu pedido foi pago", $"Pedido Nº {pedido.Numero} foi pago com sucesso!");
            logger.Log("Email enviado");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            new LojaOnline(new ConsoleLogger(), new PagarComPicPay(), new PedidoRepository(), new NotificarPorSMS());
            new LojaOnline(new JsonLogger(), new PagarComPagueSeguro(), new AtualizarPedidoFacade(), new NotificarPorEmail());
            new LojaOnline(new APILogger(), new PagarComPix(), new AtualizarPedidoFacade(), new NotificarPorPush());
        }
    }
}