using System;

// O método de subtração é uma operação matemática que subtrai um número do outro. Podemos realizar uma subtração com duas variáveis que armazenem dados do tipo numérico.

namespace Estudos_CSharp.Operações
{
    internal class Subtração
    {
        public static void executar()
        {
            int num1 = 40;
            int num2 = 19;

            Console.WriteLine(" --- OPERAÇÃO MATEMÁTICA: SUBTRAÇÃO --- \n\n");

            Console.WriteLine("Considerando dois números, o primeiro sendo " + num1 + " e o segundo sendo " + num2 + ", a subtração destes números será: " + (num1 - num2) + "\n");

            Console.WriteLine("------------------------------------------------- \n");

        }
    }
}