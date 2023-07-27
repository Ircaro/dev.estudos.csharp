using System;

namespace Estudos_CSharp._3._Operações_de_Comparação
{
    internal class MenorQue
    {
        public static void executar()
        {
            int num1 = 19;
            int num2 = 8;
            int num3 = 9;
            int num4 = 15;

            Console.WriteLine(" --- OPERAÇÕES DE COMPARAÇÃO: MENOR QUE --- \n\n");

            Console.WriteLine("O operador de comparação menor que ( < ) é utilizado para comparar dois valores e verificar se o primeiro é menor que o segundo número.\n");

            Console.WriteLine("Considerando dois números, sendo um " + num1 + " e o outro sendo " + num2 + ", se fizermos a comparação, o resultado será: " + (num1 < num2) + "\n");
            Console.WriteLine("Considerando dois números, sendo um " + num3 + " e o outro sendo " + num4 + ", se fizermos a comparação, o resultado será: " + (num3 < num4) + "\n");

            Console.WriteLine("------------------------------------------------- \n");

        }
    }
}
