using System;

namespace Estudos_CSharp._3._Operações_de_Comparação
{
    internal class MaiorOuIgual
    {
        public static void executar()
        {
            int num1 = 8;
            int num2 = 8;
            int num3 = 70;
            int num4 = 35;

            Console.WriteLine(" --- OPERAÇÕES DE COMPARAÇÃO: MAIOR OU IGUAL QUE --- \n\n");

            Console.WriteLine("O operador de comparação maior ou igual que ( >= ) é utilizado para comparar dois valores e verificar se o primeiro é maior ou igual que o segundo número.\n");

            Console.WriteLine("Considerando dois números, sendo um " + num1 + " e o outro sendo " + num2 + ", se fizermos a comparação, o resultado será: " + (num1 >= num2) + "\n");
            Console.WriteLine("Considerando dois números, sendo um " + num3 + " e o outro sendo " + num4 + ", se fizermos a comparação, o resultado será: " + (num3 >= num4) + "\n");

            Console.WriteLine("------------------------------------------------- \n");
        }
    }
}
