using System.Globalization;

namespace Grenais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int somaInter = 0;
            int somaGremio = 0;
            int empate = 0;
            int somaGrenal = 1;
            int x = 1;
            while (x == 1)
            {
                Console.Write("Digite os gols do Inter e do Grêmio: ");
                String[] linha = Console.ReadLine().Split(' ');
                int inter = int.Parse(linha[0]);
                int gremio = int.Parse(linha[1]);
                if (inter == gremio)
                {
                    empate += 1;
                }
                else if (inter > gremio)
                {
                    somaInter += 1;
                }
                else
                {
                    somaGremio += 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    x = 1;
                    somaGrenal += 1;
                }
                else
                {
                    x = 2;
                }
            }
            Console.WriteLine($"{somaGrenal} grenais");
            Console.WriteLine($"Inter:{somaInter}");
            Console.WriteLine($"Gremio:{somaGremio}");
            Console.WriteLine($"Empates:{empate}");
            if (somaGremio > empate && somaGremio > somaInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (somaInter > empate && somaInter > somaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (empate > somaGremio && empate > somaInter)
            {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}
