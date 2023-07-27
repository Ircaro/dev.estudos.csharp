using System;

namespace Estudos_CSharp._3._Operações_de_Comparação
{
    internal class MaiorQue
    {
        public static void executar()
        {
            int num1 = 48;
            int num2 = 84;
            int num3 = 70;
            int num4 = 35;

            Console.WriteLine(" --- OPERAÇÕES DE COMPARAÇÃO: MAIOR QUE --- \n\n");

            Console.WriteLine("O operador de comparação maior que ( > ) é utilizado para comparar dois valores e verificar se o primeiro é maior que o segundo número.\n");

            Console.WriteLine("Considerando dois números, sendo um " + num1 + " e o outro sendo " + num2 + ", se fizermos a comparação, o resultado será: " + (num1 > num2) + "\n");
            Console.WriteLine("Considerando dois números, sendo um " + num3 + " e o outro sendo " + num4 + ", se fizermos a comparação, o resultado será: " + (num3 > num4) + "\n");

            Console.WriteLine("------------------------------------------------- \n");
        }
    }
}
