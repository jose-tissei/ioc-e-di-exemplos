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

    public class Coordenador : ICoordenador
    {
        public ICollection<Colaborador> Colaboradores { get; private set; }

        public Coordenador()
        {
            Colaboradores = new List<Colaborador> { };
        }

        public void AddColaborador(Colaborador colaborador)
        {
            Colaboradores.Add(colaborador);
        }
    }

    public interface ICoordenador
    {
        void AddColaborador(Colaborador colaborador);
    }

    public class Programador : Colaborador { }

    public class Designer : Colaborador { }

    public class Tester : Colaborador { }

    public class BusinessAnalyst : Colaborador { }

    public class Colaborador
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}