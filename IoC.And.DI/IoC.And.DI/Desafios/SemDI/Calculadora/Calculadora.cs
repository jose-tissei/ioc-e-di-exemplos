using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.Desafios.SemDI.Calculadora
{
    /*
     * Atualmente nossa classe calculadora é capaz de somar e subtrair, precisamos
     * adicionar as funcionalidades de multiplicar e dividir, como podemos refatorar
     * a classe calculadora, para que seja possivel adicionar mais funcionalidades
     * que façam operações nos valores x e y, sem ter que alterar a classe e adicionar
     * novos métodos toda vez?
     */

    public class Calculadora
    {
        public int Soma(int x, int y) => x + y;

        public int Subtracao(int x, int y) => x - y;
    }
}