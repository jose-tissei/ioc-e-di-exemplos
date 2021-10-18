namespace IoC.And.DI.ComInjecaoDependencias.Factory.Pagamentos
{
    public class PagarComPix : IMetodoDePagamento
    {
        public MetodoPagamento MetodoPagamentoSuportado => MetodoPagamento.Pix;

        public void ProcessarPagamento(string pedido, string cartaoCredito, decimal valor)
        {
            // Se comunica com a API do Banco Central para processar o pagamento
        }
    }
}