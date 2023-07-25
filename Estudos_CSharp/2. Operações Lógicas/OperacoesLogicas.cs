using System;

// Operações lógicas são utilizadas para realizar cálculos em valores lógicos. Por exemplo, o AND, OR e NOT são operações lógicas.
// Nós podemos declarar as operações lógicas no C# com os seguintes caracteres: && (AND), || (OR) e ! (NOT).

namespace Estudos_CSharp.Operações
{
    internal class OperacoesLogicas
    {
        public static void executarAtividade()
        {
            bool verdadeiro = true;
            bool falso = false;

            Console.WriteLine(" --- OPERAÇÕES LÓGICAS --- \n\n");

            Console.WriteLine("O operador lógico AND (&&) irá retornar VERDADEIRO se TODOS os valores forem verdadeiros, exemplos: \n");

            Console.WriteLine("1. Comparando dois valores, FALSO com FALSO, o resultado será FALSO: " + (falso && falso));
            Console.WriteLine("2. Comparando dois valores, VERDADEIRO com FALSO, o resultado será FALSO: " + (verdadeiro && falso));
            Console.WriteLine("3. Comparando dois valores, FALSO com VERDADEIRO, o resultado será FALSO: " + (falso && verdadeiro));
            Console.WriteLine("4. Comparando dois valores, VERDADEIRO com VERDADEIRO, o resultado será VERDADEIRO: " + (verdadeiro && verdadeiro) + "\n");

            Console.WriteLine("O operador lógico OR (||) irá retornar VERDADEIRO se AO MENOS um valor for verdadeira, exemplos: \n");

            Console.WriteLine("5. Comparando dois valores, FALSO com FALSO, o resultado será FALSO: " + (falso || falso));
            Console.WriteLine("6. Comparando dois valores, VERDADEIRO com FALSO, o resultado será VERDADEIRO: " + (verdadeiro || falso));
            Console.WriteLine("7. Comparando dois valores, FALSO com VERDADEIRO, o resultado será VERDADEIRO: " + (falso || verdadeiro));
            Console.WriteLine("8. Comparando dois valores, VERDADEIRO com VERDADEIRO, o resultado será VERDADEIRO: " + (verdadeiro || verdadeiro) + "\n");

            Console.WriteLine("O operador lógico NOT (!) sempre irá negar um valor lógico, retornando VERDADEIRO se for FALSO e FALSO se for VERDADEIRO: \n");

            Console.WriteLine("9. Se o valor for VERDADEIRO, o resultado será FALSO: " + (!verdadeiro));
            Console.WriteLine("10. Se o valor for FALSO, o resultado será VERDADEIRO: " + (!falso) + "\n");

            Console.WriteLine("------------------------------------------------- \n");
        }
    }
}
