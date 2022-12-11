namespace Tabuada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int multi = i * n;
                Console.WriteLine($"{i} x {n} = {multi}");
            }
        }
    }
}
