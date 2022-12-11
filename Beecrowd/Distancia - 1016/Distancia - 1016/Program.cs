namespace Distancia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a distancia: ");
            int distancia = int.Parse(Console.ReadLine());
            int minutos = (60 * distancia) / 30;
            Console.WriteLine($"{minutos} minutos");
        }
    }
}