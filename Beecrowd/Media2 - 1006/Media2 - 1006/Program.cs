namespace Media2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota do aluno: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota do aluno: ");
            double C = double.Parse(Console.ReadLine());
            double media = ((A * 2) + (B * 3) + (C * 5)) / 10;
            Console.WriteLine($"MEDIA = {media.ToString("0.0")}");
        }
    }
}
