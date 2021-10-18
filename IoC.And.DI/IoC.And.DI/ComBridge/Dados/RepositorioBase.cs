using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ComBridge.Dados
{
    public abstract class RepositorioBase<T>
    {
        private readonly Armazenamento<T> armazenamento;

        public RepositorioBase(Armazenamento<T> armazenamento)
        {
            this.armazenamento = armazenamento;
        }

        public IList<T> ObterTodos()
        {
            return armazenamento.ObterTodos();
        }

        public T ObterPorId(int id)
        {
            return armazenamento.ObterPorId(id);
        }

        public void Adicionar(T registro)
        {
            armazenamento.Adicionar(registro);
        }
    }

    public class Produto { }

    public class RepositorioProduto : RepositorioBase<Produto>
    {
        public RepositorioProduto(Armazenamento<Produto> armazenamento) : base(armazenamento)
        {
        }
    }

    public class Funcionario { }

    public class RepositorioFuncionario : RepositorioBase<Funcionario>
    {
        public RepositorioFuncionario(Armazenamento<Funcionario> armazenamento) : base(armazenamento)
        {
        }
    }
}