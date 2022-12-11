namespace GastoCombustivel
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.Write("Digite o tempo gasto na viagem: ");
            int tempo = int.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade media: ");
            int velocidade = int.Parse(Console.ReadLine());
            double kilometros = tempo * velocidade;
            double combustivel = kilometros / 12;
            Console.WriteLine($"{combustivel.ToString("0.000")}");
        }
    }
}