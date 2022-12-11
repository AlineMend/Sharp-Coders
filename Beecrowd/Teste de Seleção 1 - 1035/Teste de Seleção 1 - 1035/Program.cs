namespace TetesDeSeleção1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o quatro numeros: ");
            String[] linha = Console.ReadLine().Split(' ');
            int a = int.Parse(linha[0]);
            int b = int.Parse(linha[1]);
            int c = int.Parse(linha[2]);
            int d = int.Parse(linha[3]);
            if ( b > c && d > a && (c + d) > (a + b) && c >= 0 && d >= 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            } 
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}