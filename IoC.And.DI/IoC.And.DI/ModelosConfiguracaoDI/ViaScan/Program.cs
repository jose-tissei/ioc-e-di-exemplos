using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ModelosConfiguracaoDI.ViaScan
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var services = new ServiceCollection();
            // Utilizando a lib Scrutor
            services.Scan(scan =>
                scan.FromCallingAssembly()
                    .AddClasses()
                    .AsMatchingInterface()
            );
        }
    }
}