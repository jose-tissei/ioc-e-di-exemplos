using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ComInjecaoDependencias.ViaPropriedade.Pedido
{
    public interface AtualizarPedido
    {
        void Atualizar(string pedido, string situacao);
    }
}