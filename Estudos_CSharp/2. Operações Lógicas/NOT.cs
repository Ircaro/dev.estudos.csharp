using System;

// O operador lógico NOT ( ! ) é utilizado para retornar o resultado inverso do operador. 
// Ou seja, utilizando o operador lógico em um operando verdadeiro ele se torna falso e vice-versa.

namespace Estudos_CSharp._2._Operações_Lógicas
{
    internal class NOT
    {
        public static void executar()
        {
            bool verdadeiro = true;
            bool falso = false;

            Console.WriteLine(" --- OPERAÇÕES LÓGICAS: OR --- \n\n");

            Console.WriteLine("O operador lógico NOT ( ! ) sempre irá negar um valor lógico, retornando VERDADEIRO se for FALSO e FALSO se for VERDADEIRO: \n");

            Console.WriteLine("1. Se o valor for VERDADEIRO, o resultado será FALSO: " + (!verdadeiro));
            Console.WriteLine("2. Se o valor for FALSO, o resultado será VERDADEIRO: " + (!falso) + "\n");

            Console.WriteLine("------------------------------------------------- \n");
        }
    }
}
