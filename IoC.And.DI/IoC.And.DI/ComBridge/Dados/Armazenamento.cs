using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ComBridge.Dados
{
    public interface Armazenamento<T>
    {
        public IList<T> ObterTodos();

        public T ObterPorId(int id);

        public void Adicionar(T registro);
    }

    public class ArmazenamentoEmArquivo<T> : Armazenamento<T>
    {
        public void Adicionar(T registro)
        {
            // Salvar registro no arquivo
        }

        public T ObterPorId(int id)
        {
            // Pesquisa registro dentro do arquivo por id
            return default;
        }

        public IList<T> ObterTodos()
        {
            // Retornar todos os registros do arquivo
            return default;
        }
    }

    public class ArmazenamentoNoSqlServer<T> : Armazenamento<T>
    {
        public void Adicionar(T registro)
        {
            // Insere o registro na tabela do banco de dados
        }

        public T ObterPorId(int id)
        {
            // Pesquisa o registro no banco por id
            return default;
        }

        public IList<T> ObterTodos()
        {
            // Retornar todos os registros da tabela do banco de dados
            return default;
        }
    }
}