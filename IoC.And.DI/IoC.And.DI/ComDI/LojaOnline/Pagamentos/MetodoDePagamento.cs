namespace IoC.And.DI.ComDI.LojaOnline.Pagamentos
{
    public interface MetodoDePagamento
    {
        void ProcessarPagamento(string pedido, string cartaoCredito, decimal valor);
    }
}