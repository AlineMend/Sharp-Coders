using System.Globalization;

namespace SomaÍmparesConsecutivosII
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de casos de teste: ");
            int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Digite dois numeros: ");
                    String[] linha = Console.ReadLine().Split(' ');
                    int x = int.Parse((string)linha[0]);
                    int y = int.Parse((string)linha[1]);
                    int soma = 0;
                    if (x > y)
                    {
                        int cont = x;
                        x = y;
                        y = cont;
                    }
                    for (int k = x+1; k < y; k++)
                    {
                        if (k % 2 != 0)
                        {
                            soma += k;
                        }
                    }
                Console.WriteLine(soma);
            }
        }
    }
}
