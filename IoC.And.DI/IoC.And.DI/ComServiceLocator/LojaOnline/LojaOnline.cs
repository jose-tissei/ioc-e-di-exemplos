using IoC.And.DI.ComDI.LojaOnline.Logs;
using IoC.And.DI.ComDI.LojaOnline.Notificacoes;
using IoC.And.DI.ComDI.LojaOnline.Pagamentos;
using IoC.And.DI.ComDI.LojaOnline.Pedido;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ComServiceLocator.LojaOnline
{
    public class LojaOnline
    {
        private readonly Logger logger;
        private readonly MetodoDePagamento metodoDePagamento;
        private readonly AtualizarPedido atualizarPedido;
        private readonly Notificacao notificacao;

        public LojaOnline(ServiceLocator serviceLocator)
        {
            logger = serviceLocator.Resolver<Logger>();
            metodoDePagamento = serviceLocator.Resolver<MetodoDePagamento>();
            atualizarPedido = serviceLocator.Resolver<AtualizarPedido>();
            notificacao = serviceLocator.Resolver<Notificacao>();
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