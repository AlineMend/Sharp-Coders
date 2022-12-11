using System.Globalization;

namespace CrescenteDecrescente
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j = 0;
            while (j == 0)
            {
                Console.Write("Digite dois valores: ");
                String[] linha = Console.ReadLine().Split(' ');
                int x = int.Parse(linha[0]);
                int y = int.Parse(linha[1]);
                if (x == y)
                {
                    break;
                }
                else if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            }
        }
    }
}
