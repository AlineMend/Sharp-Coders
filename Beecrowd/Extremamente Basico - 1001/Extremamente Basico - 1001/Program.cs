using System;

namespace ExtremamenteBasico
{
    public class program
    {
        public static void Main(String[] args)
        {
            Console.Write("Digite um numero inteiro:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite um numero inteiro:");
            int B = int.Parse(Console.ReadLine());
            int soma = A + B;
            Console.WriteLine($"X = {soma}");
        }
    }
}