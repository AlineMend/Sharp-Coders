namespace Diferença
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto numero: ");
            int D = int.Parse(Console.ReadLine());
            int dif = (A * B - C * D);
            Console.WriteLine($"DIFERENCA = {dif}");
        }
    }
}
