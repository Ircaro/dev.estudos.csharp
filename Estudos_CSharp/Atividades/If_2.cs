using System;

// Atividade 1045 do BeeCrowd (Antigo URI Online Judge)

// leia 3 valores de ponto flutuante a, b e c e ordene-os em ordem decrescente, de modo que o lado a representa o maior dos 3 lados. a seguir, determine o tipo de
// triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
// se a ≥ b + c, apresente a mensagem: NÃO FORMA TRIÂNGULO
// se a^2 = b^2 + c^2, apresente a mensagem: TRIÂNGULO RETÂNGULO
// se a^2 > b^2 + c^2, apresente a mensagem: TRIÂNGULO OBTUSÂNGULO
// se a^2 < b^2 + c^2, apresente a mensagem: TRIÂNGULO ACUTÂNGULO
// se os três lados forem iguais, apresente a mensagem: TRIÂNGULO EQUILÁTERO
// se apenas dois dos lados forem iguais, apresente a mensagem: TRIÂNGULO ISÓSCELES

// ENTRADA
// a entrada contem três valores de ponto flutuante de dupla precisão a (0 < a) , b(0 < b) e c(0 < c).

// SAÍDA
// imprima todas as classificações do triângulo especificado na entrada.

namespace Estudos_CSharp.Atividades
{
    internal class If_2
    {
        public static void executarAtividade()
        {
            Console.Write("Digite os três lados do triângulo: ");

            var input = Console.ReadLine().Split(" ");
            if (input.Length != 3)
            {
                Console.WriteLine("Entrada Inválida.");
                return; // Early Return
            }
            float[] lados = new float[3];

            float.TryParse(input[0], out lados[0]);
            float.TryParse(input[1], out lados[1]);
            float.TryParse(input[2], out lados[2]);

            Array.Sort(lados);
            Array.Reverse(lados);

            float ladoA = lados[0];
            float ladoB = lados[1];
            float ladoC = lados[2];

            if (ladoA >= (ladoB + ladoC))
            {
                Console.WriteLine("NÃO FORMA TRIÂNGULO");
            }
            else
            {
                if (Math.Pow(ladoA, 2) == (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
                {
                    Console.WriteLine("TRIÂNGULO RETÂNGULO");
                }

                if (Math.Pow(ladoA, 2) > (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
                {
                    Console.WriteLine("TRIÂNGULO OBTUSÂNGULO");
                }

                if (Math.Pow(ladoA, 2) < (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
                {
                    Console.WriteLine("TRIÂNGULO ACUTÂNGULO");
                }

                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("TRIÂNGULO EQUILÁTERO");
                }

                if (((ladoA == ladoB) && ladoA != ladoC) || ((ladoB == ladoC) && ladoB != ladoA ))
                {
                    Console.WriteLine("TRIÂNGULO ISÓSCELES");
                }
            }
        }

    }
}