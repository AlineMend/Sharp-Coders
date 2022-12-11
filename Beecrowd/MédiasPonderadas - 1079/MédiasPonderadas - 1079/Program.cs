namespace MédiasPonderadas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o número de casos de teste: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite três valores: ");
                String[] linha = Console.ReadLine().Split(' ');
                double numero1 = double.Parse(linha[0]);
                double numero2 = double.Parse(linha[1]);
                double numero3 = double.Parse(linha[2]);
                double media = ((numero1 * 2) + (numero2 * 3) + (numero3 * 5)) / 10;
                Console.WriteLine(media.ToString("0.0"));
            }
        }
    }
}
