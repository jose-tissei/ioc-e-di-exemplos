namespace IoC.And.DI.ComDI.LojaOnline.Pagamentos
{
    public class PagarComPicPay : MetodoDePagamento
    {
        public void ProcessarPagamento(string pedido, string cartaoCredito, decimal valor)
        {
            // Se comunica com a API do PicPay para processar o pagamento
        }
    }
}