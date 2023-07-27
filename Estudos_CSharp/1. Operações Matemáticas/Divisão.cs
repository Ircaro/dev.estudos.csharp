using System;

// O método de divisão é uma operação matemática que realiza a divisão entre dois números. Podemos realizar uma divisão com duas variáveis que armazenem dados do tipo numérico.
// Se as variáveis deste método forem do tipo inteiro (int), o resultado não terá decimais.

namespace Estudos_CSharp.Operações
{
    internal class Divisão
    {
        public static void executar()
        {
            int num1 = 63;
            int num2 = 9;

            Console.WriteLine(" --- OPERAÇÃO MATEMÁTICA: DIVISÃO --- \n\n");

            Console.WriteLine("Considerando dois números, o primeiro sendo " + num1 + " e o segundo sendo " + num2 + ", a divisão destes números será: " + (num1 / num2) + "\n");

            Console.WriteLine("------------------------------------------------- \n");

        }
    }
}