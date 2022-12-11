namespace ConversãoTempo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o tempo de duração em segundos: ");
            int tempo = int.Parse(Console.ReadLine());
            int horas = tempo / 3600;
            int minutos = (tempo % 3600) / 60;
            int segundos = (tempo % 3600) % 60;
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
