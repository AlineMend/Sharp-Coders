namespace TempoDeJogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a hora inicial e final do jogo: ");
            String[] linha = Console.ReadLine().Split(' ');
            int hInicio = int.Parse(linha[0]);
            int hFim = int.Parse(linha[1]);
            if (hFim > hInicio)
            {
                int hTotal = hFim - hInicio;
                Console.WriteLine($"O JOGO DUROU {hTotal} HORA(S)");
            }
            else if (hFim < hInicio)
            {
                int hTotal = 24 + hFim - hInicio;
                Console.WriteLine($"O JOGO DUROU {hTotal} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S");
            }
        }
    }
}