using System;

// O método de soma é uma operação matemática que adiciona um número ao outro. Podemos realizar uma soma com duas variáveis que armazenem dados do tipo numérico.

namespace Estudos_CSharp.Operações
{
    internal class Soma
    {
        public static void executar()
        {
            int num1 = 11;
            int num2 = 27;

            Console.WriteLine(" --- OPERAÇÃO MATEMÁTICA: SOMA --- \n\n");

            Console.WriteLine("Considerando dois números, o primeiro sendo " + num1 + " e o segundo sendo " + num2 + ", a soma destes números será: " + (num1 + num2) + "\n");

            Console.WriteLine("------------------------------------------------- \n");

        }
    }
}