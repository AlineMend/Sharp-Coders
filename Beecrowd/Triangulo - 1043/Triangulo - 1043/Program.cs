namespace Triangulo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite três numeros: ");
            String[] linha = Console.ReadLine().Split(' ');
            double a = double.Parse(linha[0]);
            double b = double.Parse(linha[1]);
            double c = double.Parse(linha[2]);
            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                double perimetro = a + b + c;

                Console.WriteLine($"Perimetro = {perimetro.ToString("0.0")}");
            }
            else
            {
                double area = ((a + b) * c) / 2;

                Console.WriteLine($"Area = {area.ToString("0.0")}");
            }
        }
    }
}
