namespace Media1
{
    public class Program
    {
        private const double V = 0.00000;

        public static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota do aluno:");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno:");
            double B = double.Parse(Console.ReadLine());
            double media = ((A * 3.5) + (B * 7.5)) / 11;
            Console.WriteLine($"MEDIA = {media.ToString("0.00000")}");

        }
    }
}
