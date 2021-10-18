namespace IoC.And.DI.ComInjecaoDependencias.Factory.Pagamentos
{
    public interface IMetodoDePagamento
    {
        void ProcessarPagamento(string pedido, string cartaoCredito, decimal valor);

        MetodoPagamento MetodoPagamentoSuportado { get; }
    }
}