namespace Bhaskara
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite quatro numeros: ");
            String[] linha = Console.ReadLine().Split(' ');
            double a = double.Parse(linha[0]);
            double b = double.Parse(linha[1]);
            double c = double.Parse(linha[2]);
            double delta = (Math.Pow(b,2) - (4 * a * c));
            double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            if (a != 0 && delta > 0)
            {
                Console.WriteLine($"R1 = {r1.ToString("0.00000")}");
                Console.WriteLine($"R2 = {r2.ToString("0.00000")}");
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
