using System;

namespace ESTRUTURA_LOOP_DE_REPETIÇÃO_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Escreva um programa que calcule a soma dos números de 1 a 100 usando um loop for.

            Console.WriteLine("Irei calcular a soma dos números de 1 a 100.");
            int numero = 100;

            for (int i = 1; i <= 100; i++) 
            {
                numero += i;
            }

            Console.WriteLine($"A soma dos números de 1 a 100 é: {numero}");
        }
    }
}
