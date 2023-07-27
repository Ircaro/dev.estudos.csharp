using System;

// O operador lógico AND ( && ) é utilizado para verificar dois ou mais operandos e só retornará verdadeiro se todos os operandos forem verdadeiros.

namespace Estudos_CSharp._2._Operações_Lógicas
{
    internal class AND
    {
        public static void executar() 
        {
            bool verdadeiro = true;
            bool falso = false;

            Console.WriteLine(" --- OPERAÇÕES LÓGICAS: AND --- \n\n");

            Console.WriteLine("O operador lógico AND ( && ) irá retornar VERDADEIRO se TODOS os valores forem verdadeiros, exemplos: \n");

            Console.WriteLine("1. Comparando dois valores, FALSO com FALSO, o resultado será FALSO: " + (falso && falso));
            Console.WriteLine("2. Comparando dois valores, VERDADEIRO com FALSO, o resultado será FALSO: " + (verdadeiro && falso));
            Console.WriteLine("3. Comparando dois valores, FALSO com VERDADEIRO, o resultado será FALSO: " + (falso && verdadeiro));
            Console.WriteLine("4. Comparando dois valores, VERDADEIRO com VERDADEIRO, o resultado será VERDADEIRO: " + (verdadeiro && verdadeiro) + "\n");

            Console.WriteLine("------------------------------------------------- \n");
        }
    }
}
