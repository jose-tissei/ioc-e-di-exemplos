namespace IoC.And.DI.ComDI.LojaOnline.Pagamentos
{
    public class PagarComPagueSeguro : MetodoDePagamento
    {
        public void ProcessarPagamento(string pedido, string cartaoCredito, decimal valor)
        {
            // Se comunica com a API do Pague Seguro para processar o pagamento
        }
    }
}