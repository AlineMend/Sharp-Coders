namespace ParOuÍmpar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Digite o {i}° numero: ");
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                if (x % 2 == 0 && x != 0)
                {
                    Console.Write("EVEN ");
                }
                else if (x % 2 != 0)
                {
                    Console.Write("ODD ");
                }
                if (x > 0)
                {
                    Console.WriteLine("POSITIVE");
                }
                else if (x < 0)
                {
                    Console.WriteLine("NEGATIVE");
                }
            }
        }
    }
}
