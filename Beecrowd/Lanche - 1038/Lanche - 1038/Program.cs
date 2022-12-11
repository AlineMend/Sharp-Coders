using System.Collections.Concurrent;

namespace Lanche
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o codigo e a quantidade do item: ");
            String[] linha = Console.ReadLine().Split(' ');
            int condigo = int.Parse(linha[0]);
            int quantidade = int.Parse(linha[1]);
            if (condigo == 1)
            {
                double total = quantidade * 4;
                Console.WriteLine($"Total: R$ {total.ToString("0.00")}");
            }
            else if (condigo == 2)
            {
                double total = quantidade * 4.5;
                Console.WriteLine($"Total: R$ {total.ToString("0.00")}");
            }
            else if (condigo == 3)
            {
                double total = quantidade * 5;
                Console.WriteLine($"Total: R$ {total.ToString("0.00")}");
            }
            else if (condigo == 4)
            {
                double total = quantidade * 2;
                Console.WriteLine($"Total: R$ {total.ToString("0.00")}");
            }
            else
            {
                double total = quantidade * 1.5;
                Console.WriteLine($"Total: R$ {total.ToString("0.00")}");
            }
        }
    }
}
