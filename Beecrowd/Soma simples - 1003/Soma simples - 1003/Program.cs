namespace SomaSimples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero:");
            int B = int.Parse(Console.ReadLine());
            int soma = A + B;
            Console.WriteLine($"SOMA = {soma}");

        }
    }
}