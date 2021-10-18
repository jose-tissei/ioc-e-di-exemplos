using IoC.And.DI.ComDI.LojaOnline.Notificacoes;
using IoC.And.DI.ComDI.LojaOnline.Pagamentos;
using IoC.And.DI.ComDI.LojaOnline.Pedido;
using IoC.And.DI.ComDI.LojaOnline;
using System;
using System.Collections.Generic;
using System.Text;
using IoC.And.DI.ComDI.LojaOnline.Logs;
using IoC.And.DI.ComInjecaoDependencias.Factory.Pagamentos;

namespace IoC.And.DI.ComInjecaoDependencias.Factory
{
    public class LojaOnline : ILojaOnline
    {
        private readonly Logger logger;
        private readonly IMetodoDePagamento metodoDePagamento;
        private readonly AtualizarPedido atualizarPedido;
        private readonly Notificacao notificacao;

        public LojaOnline(
            Logger logger,
            IMetodoDePagamento metodoDePagamento,
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
}