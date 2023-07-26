using System;

// O operador lógico OR (||) é utilizado para verificar dois ou mais operandos e só retornará verdadeiro se ao menos um dos operandos forem verdadeiros.

namespace Estudos_CSharp._2._Operações_Lógicas
{
    internal class OR
    {
        public static void executarAtividade() 
        {
            bool verdadeiro = true;
            bool falso = false;

            Console.WriteLine(" --- OPERAÇÕES LÓGICAS: OR --- \n\n");

            Console.WriteLine("O operador lógico OR (||) irá retornar VERDADEIRO se AO MENOS um valor for verdadeira, exemplos: \n");

            Console.WriteLine("1. Comparando dois valores, FALSO com FALSO, o resultado será FALSO: " + (falso || falso));
            Console.WriteLine("2. Comparando dois valores, VERDADEIRO com FALSO, o resultado será VERDADEIRO: " + (verdadeiro || falso));
            Console.WriteLine("3. Comparando dois valores, FALSO com VERDADEIRO, o resultado será VERDADEIRO: " + (falso || verdadeiro));
            Console.WriteLine("4. Comparando dois valores, VERDADEIRO com VERDADEIRO, o resultado será VERDADEIRO: " + (verdadeiro || verdadeiro) + "\n");
        }
    }
}
