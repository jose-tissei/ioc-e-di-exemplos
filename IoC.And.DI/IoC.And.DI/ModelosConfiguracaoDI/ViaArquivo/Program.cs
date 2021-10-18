using Autofac;
using Autofac.Configuration;
using IoC.And.DI.ComDI.LojaOnline;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ModelosConfiguracaoDI.ViaArquivo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Add the configuration to the ConfigurationBuilder.
            var config = new ConfigurationBuilder();
            // config.AddJsonFile comes from Microsoft.Extensions.Configuration.Json
            config.AddJsonFile("autofac.json");

            // Register the ConfigurationModule with Autofac.
            var module = new ConfigurationModule(config.Build());
            var builder = new ContainerBuilder();
            builder.RegisterModule(module);
            var container = builder.Build();
            var lojaOnline = container.Resolve<ILojaOnline>();
        }
    }
}