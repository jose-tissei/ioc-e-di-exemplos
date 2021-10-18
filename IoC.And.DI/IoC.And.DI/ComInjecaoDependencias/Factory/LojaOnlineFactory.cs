using IoC.And.DI.ComDI.LojaOnline;
using IoC.And.DI.ComDI.LojaOnline.Logs;
using IoC.And.DI.ComDI.LojaOnline.Notificacoes;
using IoC.And.DI.ComDI.LojaOnline.Pedido;
using IoC.And.DI.ComInjecaoDependencias.Factory.Pagamentos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IoC.And.DI.ComInjecaoDependencias.Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<Logger, ConsoleLogger>();

            services.AddScoped<IMetodoDePagamento, PagarComPagueSeguro>();
            services.AddScoped<IMetodoDePagamento, PagarComPicPay>();
            services.AddScoped<IMetodoDePagamento, PagarComPix>();

            services.AddScoped<AtualizarPedido, AtualizarPedidoFacade>();
            services.AddTransient<Notificacao, NotificarPorEmail>();

            var container = services.BuildServiceProvider();
            container.GetRequiredService<ILojaOnlineFactory>().Fabricar(MetodoPagamento.PagSeguro);
        }
    }

    public enum MetodoPagamento
    {
        Pix,
        PagSeguro,
        PicPay
    }

    public interface ILojaOnlineFactory
    {
        ILojaOnline Fabricar(MetodoPagamento metodoPagamento);
    }

    public class LojaOnlineFactory : ILojaOnlineFactory
    {
        private readonly IServiceProvider serviceProvider;

        public LojaOnlineFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public ILojaOnline Fabricar(MetodoPagamento metodoPagamento)
        {
            var servicoPagamento = serviceProvider
                                    .GetServices<IMetodoDePagamento>()
                                    .Single(x => x.MetodoPagamentoSuportado == metodoPagamento);
            return new LojaOnline(
                serviceProvider.GetRequiredService<Logger>(),
                servicoPagamento,
                serviceProvider.GetRequiredService<AtualizarPedido>(),
                serviceProvider.GetRequiredService<Notificacao>()
            );
        }
    }
}