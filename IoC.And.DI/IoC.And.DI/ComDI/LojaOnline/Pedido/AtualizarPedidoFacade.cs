namespace IoC.And.DI.ComDI.LojaOnline.Pedido
{
    public class AtualizarPedidoFacade : AtualizarPedido
    {
        public void Atualizar(string pedido, string situacao)
        {
            // PedidoRepository.AtualizarPedido
            // Publicar auditoria
            // Publicar evento de atualizacao para outros microservicos ou sistemas
            // Fica de curiosidade pra uma proxima talk sobre Facade, Decorators e Scrutor
        }
    }
}