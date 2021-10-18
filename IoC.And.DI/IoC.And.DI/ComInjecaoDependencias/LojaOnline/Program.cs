using IoC.And.DI.ComDI.LojaOnline;
using IoC.And.DI.ComDI.LojaOnline.Logs;
using IoC.And.DI.ComDI.LojaOnline.Notificacoes;
using IoC.And.DI.ComDI.LojaOnline.Pagamentos;
using IoC.And.DI.ComDI.LojaOnline.Pedido;
using Microsoft.Extensions.DependencyInjection;

namespace IoC.And.DI.ComInjecaoDependencias.LojaOnline
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<Logger, ConsoleLogger>();
            services.AddScoped<MetodoDePagamento, PagarComPagueSeguro>();
            services.AddScoped<AtualizarPedido, AtualizarPedidoFacade>();
            services.AddTransient<Notificacao, NotificarPorEmail>();
            services.AddScoped<ComDI.LojaOnline.LojaOnline, ComDI.LojaOnline.LojaOnline>();
            services.AddScoped<ILojaOnline, ComDI.LojaOnline.LojaOnline>();
            var container = services.BuildServiceProvider();

            var lojaOnlineViaInterface = container.GetRequiredService<ILojaOnline>();
            lojaOnlineViaInterface.ProcessarPedido(new SemDI.LojaOnline.Pedido());

            var lojaOnlineViaClasse = container.GetRequiredService<ComDI.LojaOnline.LojaOnline>();
            lojaOnlineViaClasse.ProcessarPedido(new SemDI.LojaOnline.Pedido());
        }
    }
}