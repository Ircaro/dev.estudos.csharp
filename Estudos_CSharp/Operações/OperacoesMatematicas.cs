using System;

// Operações matemáticas: são usadas para realizar cálculos em números. Por exemplo, a adição, subtração, multiplicação e divisão são operações matemáticas.
// Considerando dois números, o primeiro sendo 10 e o segundo sendo 5, podemos seguir fazendo algumas operações, utilizando os símbolos "+", "-", "*" e "/".

namespace Estudos_CSharp.Operações
{
    internal class OperacoesMatematicas
    {
        public static void executarAtividade()
        {
            int num1 = 10;
            int num2 = 5;

            Console.WriteLine(" --- OPERAÇÕES MATEMÁTICAS --- \n\n");

            Console.WriteLine("Considerando dois números, o primeiro sendo " + num1 + " e o segundo sendo " + num2 + ", podemos realizar as seguintes operações: \n");

            Console.WriteLine("A soma dos números será: " + (num1 + num2));
            Console.WriteLine("A subtração dos números será: " + (num1 - num2));
            Console.WriteLine("A multiplicação dos números será: " + (num1 * num2));
            Console.WriteLine("A divisão dos números será: " + (num1 / num2) + "\n");

            Console.WriteLine("------------------------------------------------- \n");

        }
    }
}