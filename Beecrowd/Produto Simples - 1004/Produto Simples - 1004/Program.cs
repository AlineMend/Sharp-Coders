namespace ProdutoSimples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primero numero:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite o primero numero:");
            int B = int.Parse(Console.ReadLine());
            int mult = A * B;
            Console.WriteLine($"PROD = {mult}" );

        }
    }
}
