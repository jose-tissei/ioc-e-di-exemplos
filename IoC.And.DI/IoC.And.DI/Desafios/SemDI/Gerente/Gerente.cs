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
        private IList<Programador> programadores;
        private IList<Designer> designers;
        private IList<Tester> testers;

        public Coordenador()
        {
            programadores = new Programador[] { };
            designers = new Designer[] { };
            testers = new Tester[] { };
        }

        public void AddProgramador(Programador programador)
        {
            programadores.Add(programador);
        }

        public void AddDesigner(Designer designer)
        {
            designers.Add(designer);
        }

        public void AddTester(Tester tester)
        {
            testers.Add(tester);
        }
    }

    public class Programador
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    public class Designer
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    public class Tester
    {
        public decimal Salario { get; set; }
        public int SaldoFerias { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}