using System;

// O método de multiplicação é uma operação matemática que realiza o produto entre dois números. Podemos realizar uma multiplicação com duas variáveis que armazenem dados do tipo numérico.

namespace Estudos_CSharp.Operações
{
    internal class Multiplicação
    {
        public static void executar()
        {
            int num1 = 7;
            int num2 = 5;

            Console.WriteLine(" --- OPERAÇÃO MATEMÁTICA: MULTIPLICAÇÃO --- \n\n");

            Console.WriteLine("Considerando dois números, o primeiro sendo " + num1 + " e o segundo sendo " + num2 + ", a multiplicação destes números será: " + (num1 * num2) + "\n");

            Console.WriteLine("------------------------------------------------- \n");

        }
    }
}