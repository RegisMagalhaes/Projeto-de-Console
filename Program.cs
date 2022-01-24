using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma calculadora que faça a soma de 2 números inteiros");
            //Entrada
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            //Processamento
            int soma = num1+num2;
            //Saída
            Console.Write("O resultado de " +num1+ " + " +num2+ " é " +soma);
        }
    }
}
