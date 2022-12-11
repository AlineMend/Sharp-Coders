namespace area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite três numeros: ");
            string[] linha = Console.ReadLine().Split(' ');
            double A = double.Parse(linha[0]);
            double B = double.Parse(linha[1]);
            double C = double.Parse(linha[2]);
            double triangulo = (A * C) / 2;
            double circulo = 3.14159 * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;
            Console.WriteLine($"TRIANGULO: {triangulo.ToString("0.000")}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("0.000")}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("0.000")}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("0.000")}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("0.000")}");

        }
    }
}