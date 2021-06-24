namespace IoC.And.DI.ComDI.LojaOnline.Pagamentos
{
    public class PagarComPix : MetodoDePagamento
    {
        public void ProcessarPagamento(string pedido, string cartaoCredito, decimal valor)
        {
            // Se comunica com a API do Banco Central para processar o pagamento
        }
    }
}