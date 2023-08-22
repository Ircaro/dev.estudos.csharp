using System;
using System.Security.Cryptography.X509Certificates;

namespace Estudos_CSharp._4._Operações_de_Atribuição
{
    internal class AtribuiçãoSimples
    {
        public static void executar()
        {
            Console.WriteLine(" --- OPERAÇÕES DE ATRIBUIÇÃO: ATRIBUIÇÃO SIMPLES --- \n\n");

            Console.WriteLine("A atribuição simples ( = ) é utilizada para armazenar um valor em uma variável\n\n");

            Console.WriteLine("Para criar e atribuir um valor a uma variárvel é necessário informar o tipo da variável, nome da variável e o valor que está se atribuindo a ela, necessariamente nessa ordem.\n\n");

            Console.WriteLine("Exemplo: int idade = 20\n\n");

            Console.WriteLine("No exemplo, estamos declarando uma variável com o tipo int (inteiro) com o nome idade e atribuindo o valor de 20 para ela.\n\n");

            int idade = 20;

            Console.WriteLine("No momento, o valor da nossa variável idade está com o valor: " + idade + "\n\n");

            Console.WriteLine("Mas é possível alterar o valor que contém na variável, neste caso, não precisamos mais informar o tipo, pois ele já foi declarado, ficando somente: idade = 30, por exemplo: \n\n");

            idade = 30;

            Console.WriteLine("E agora o valor da variável está igual a: " + idade + "\n\n");

            Console.WriteLine("Existem outros tipos de variáveis além do int, como double, string, bool, etc.\n\n");

            Console.WriteLine("------------------------------------------------- \n");

        }
    }
}
