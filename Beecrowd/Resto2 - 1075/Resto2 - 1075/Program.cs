namespace Resto2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10000; i++)
            {
                if (i % n == 2) 
                { 
                    Console.WriteLine(i);
                }
            }
        }
    }
}
