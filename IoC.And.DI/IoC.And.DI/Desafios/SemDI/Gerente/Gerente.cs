using System;
using System.Collections.Generic;

namespace IoC.And.DI.Desafios.SemDI.Gerente
{
    /* Nosso sistema atualmente tem uma estrutura de classes onde coordenadores são responsaveis
     * por programadores, testers e designers, precisamos agora que os coordenadores também sejam
     * responsaveis por analistas de negócio, como podemos reestruturar nosso código para que não
     * seja necessário mais alterar a classe Coordenador toda vez que precisarmos adicionar um novo
     * tipo de funcionario?
     */

    public class Coordenador
    {
        private IList<IColaborador> colaboradores;

        public Coordenador()
        {
            colaboradores = new IColaborador[] { };
        }

        public void AddColaborador(IColaborador colaborador)
        {
            colaboradores.Add(colaborador);
        }
    }

    public interface IColaborador
    {
    }

    public class Programador : IColaborador
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    public class Designer : IColaborador
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    public class Tester : IColaborador
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    public class Negocio : IColaborador
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var gerente = new Coordenador();
            gerente.AddColaborador(new Programador());
            gerente.AddColaborador(new Designer());
            gerente.AddColaborador(new Tester());
            gerente.AddColaborador(new Negocio());
        }
    }
}