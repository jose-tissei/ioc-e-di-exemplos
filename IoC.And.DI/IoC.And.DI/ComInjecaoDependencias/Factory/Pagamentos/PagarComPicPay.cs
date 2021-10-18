namespace IoC.And.DI.ComInjecaoDependencias.Factory.Pagamentos
{
    public class PagarComPicPay : IMetodoDePagamento
    {
        public MetodoPagamento MetodoPagamentoSuportado => MetodoPagamento.PicPay;

        public void ProcessarPagamento(string pedido, string cartaoCredito, decimal valor)
        {
            // Se comunica com a API do PicPay para processar o pagamento
        }
    }
}