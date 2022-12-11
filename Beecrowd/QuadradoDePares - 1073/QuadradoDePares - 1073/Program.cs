namespace QuadradoDePares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int quadrado = i * i;
                    Console.WriteLine($"{i}^2 = {quadrado}");
                }
            }
        }
    }
}