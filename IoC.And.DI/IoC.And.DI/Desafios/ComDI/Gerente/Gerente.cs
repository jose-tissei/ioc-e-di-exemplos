using System;
using System.Collections.Generic;

namespace IoC.And.DI.Desafios.ComDI.Gerente
{
    /* Nosso sistema atualmente tem uma estrutura de classes onde coordenadores são responsaveis
     * por programadores, testers e designers, precisamos agora que os coordenadores também sejam
     * responsaveis por analistas de negócio, como podemos reestruturar nosso código para que não
     * seja necessário mais alterar a classe Coordenador toda vez que precisarmos adicionar um novo
     * tipo de funcionario?
     */

    public interface IColaborador
    {
    }

    public class Coordenador
    {
        private IList<IColaborador> _colaboradores; 

        public Coordenador()
        {
        }

        public Coordenador AddColaborador(IColaborador colaborador)
        {
            _colaboradores.Add(colaborador);
            return this;
        }
    }

    public enum TipoColaborador
    {
        Programador,
        Designer,
        Tester,
        Analista_De_Negocios
    }

    public class Colaborador : IColaborador
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
        public TipoColaborador TipoColaborador { get; protected set; }
    }

    public class Programador : Colaborador
    {
        public Programador()
        {
            TipoColaborador = TipoColaborador.Programador;
        }
    }

    public class Designer : Colaborador
    {
        public Designer()
        {
            TipoColaborador = TipoColaborador.Designer;
        }
    }

    public class Tester : Colaborador
    {
        public Tester()
        {
            TipoColaborador = TipoColaborador.Tester;
        }
    }

    public class AnalistaDeNegocios : Colaborador
    {
        public AnalistaDeNegocios()
        {
            TipoColaborador = TipoColaborador.Analista_De_Negocios;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            new Coordenador()
                .AddColaborador(new Programador())
                .AddColaborador(new Designer())
                .AddColaborador(new AnalistaDeNegocios())
                .AddColaborador(new Tester());
        }
    }
}