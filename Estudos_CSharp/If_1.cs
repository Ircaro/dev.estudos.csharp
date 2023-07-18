using System;

// Escrever um programa que solicite ao usuário um número e verifique se esse número é positivo, negativo ou zero.

// Solicite ao usuário um número.
// Verifique se o número é positivo, negativo ou zero.
// Exiba a seguinte mensagem de acordo com o número inserido:
//  Se o número for positivo, exiba: "O número é positivo".
//  Se o número for negativo, exiba: "O número é negativo".
//  Se o número for zero, exiba: "O número é zero".

class Atividade_1 {

    static void Main(string[] args) { 

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        } else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        } else
        {
            Console.WriteLine("O número é zero.");
        }

    }

}