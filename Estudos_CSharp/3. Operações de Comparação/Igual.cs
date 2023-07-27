using System;

namespace Estudos_CSharp._3._Operações_de_Comparação
{
    internal class Igual
    {
        public static void executar()
        {
            int num1 = 80;
            int num2 = 80;

            Console.WriteLine(" --- OPERAÇÕES DE COMPARAÇÃO: IGUAL A --- \n\n");

            Console.WriteLine("O operador de comparação igual ( == ) é utilizado para comparar dois valores, será retornado true (verdadeiro) se ambos os valores forem iguais.\n");

            Console.WriteLine("Considerando dois números, sendo um " + num1 + " e o outro sendo " + num2 + ", se fizermos a comparação, o resultado será: " + (num1 == num2) + "\n");

            Console.WriteLine("------------------------------------------------- \n");
        }
    }
}
