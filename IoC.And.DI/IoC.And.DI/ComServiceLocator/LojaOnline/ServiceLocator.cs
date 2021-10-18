using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ComServiceLocator.LojaOnline
{
    // Normalmente seria um singleton
    public class ServiceLocator
    {
        private readonly IDictionary<Type, object> servicos;

        public ServiceLocator()
        {
            servicos = new Dictionary<Type, object>();
        }

        public TServico Resolver<TServico>()
        {
            return (TServico)servicos[typeof(TServico)];
        }

        public void Registrar<TServico>(object servico)
        {
            servicos[typeof(TServico)] = servico;
        }
    }
}