namespace Esfera
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o raio da esfera: ");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double volume = (4.0 / 3) * pi * Math.Pow(r, 3);
            Console.WriteLine($"VOLUME = {volume.ToString("0.000")}");
        }
    }
}
