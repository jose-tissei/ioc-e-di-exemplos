using DotNurse.Injector.Attributes;
using System;

namespace IoC.And.DI.ComInjecaoDependencias.ViaPropriedade.Pedido
{
    public interface Auditoria
    {
        void Publicar(DateTime timestamp, string pedido, string situacao);
    }

    public class AtualizarPedidoFacade : AtualizarPedido
    {
        // Desse modo vai gerar referencia ciclica e quebrar o container de DI
        private readonly AtualizarPedido pedidoRepository;

        // Utilizando a biblioteca Nurse, poderia usar também Autofac
        [InjectService] public Auditoria Auditoria { get; set; }

        public AtualizarPedidoFacade(AtualizarPedido pedidoRepository)
        {
            this.pedidoRepository = pedidoRepository;
        }

        public void Atualizar(string pedido, string situacao)
        {
            pedidoRepository.Atualizar(pedido, situacao);
            Auditoria?.Publicar(DateTime.Now, pedido, situacao);
            // Publicar auditoria
            // Publicar evento de atualizacao para outros microservicos ou sistemas
            // Fica de curiosidade pra uma proxima talk sobre Facade, Decorators e Scrutor
        }
    }
}