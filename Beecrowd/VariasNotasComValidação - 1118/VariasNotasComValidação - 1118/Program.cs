using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace VariasNotasComValidação
{
    public class Program
    {
        static void CalcularMedia()
        {
            int j = 0;
            double soma = 0;
            while (j >= 0 && j < 2)
            {
                Console.Write("Digite a nota do aluno:");
                double nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    soma = soma + nota;
                    j++;
                }
            }
            double media = soma / 2;
            Console.WriteLine($"media = {media.ToString("0.00")}");
        }
        public static void Main(string[] args)
        {
            CalcularMedia();
            int k = 0;
            while (k == 0 || k ==1)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                int resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    CalcularMedia();
                }
                else if (resposta < 1 || resposta > 2)
                {
                    k = 1;
                }
                else
                {
                    k = 2;
                }
            }

        }
    }
}

