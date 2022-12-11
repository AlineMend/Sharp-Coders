namespace AreadoCirculo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um raio:");
            double r = double.Parse(Console.ReadLine());
            double area = (3.14159 * Math.Pow(r,2));
            Console.WriteLine("A=" + area.ToString("0.0000"));
        }
    }
}
