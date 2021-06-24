using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ComDI.LojaOnline.Pedido
{
    public interface AtualizarPedido
    {
        void Atualizar(string pedido, string situacao);
    }
}