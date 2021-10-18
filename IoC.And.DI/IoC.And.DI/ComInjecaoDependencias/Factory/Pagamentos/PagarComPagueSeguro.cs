namespace IoC.And.DI.ComInjecaoDependencias.Factory.Pagamentos
{
    public class PagarComPagueSeguro : IMetodoDePagamento
    {
        public MetodoPagamento MetodoPagamentoSuportado => MetodoPagamento.PagSeguro;

        public void ProcessarPagamento(string pedido, string cartaoCredito, decimal valor)
        {
            // Se comunica com a API do Pague Seguro para processar o pagamento
        }
    }
}