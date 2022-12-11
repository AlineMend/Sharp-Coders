namespace Consumo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a distancia total percorrida: ");
            int dis = int.Parse(Console.ReadLine());
            Console.Write("Digite o total de combustivel gasto: ");
            double comb = double.Parse(Console.ReadLine());
            double consumo = dis / comb;
            Console.WriteLine($"{consumo.ToString("0.000")} km/l");
        }
    }
}