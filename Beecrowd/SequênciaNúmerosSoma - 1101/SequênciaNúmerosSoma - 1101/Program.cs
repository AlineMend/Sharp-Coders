namespace SequênciaNúmerosSoma
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int j = 0;
            int soma = 0;
            while (j == 0)
            {
                Console.Write("Digite dois numeros: ");
                string[] linha = Console.ReadLine().Split(' ');
                int m = int.Parse(linha[0]);
                int n = int.Parse(linha[1]);
                if (m <= 0 || n <= 0)
                {
                    break;
                }
                if (m > n)
                {
                    int cont = m;
                    m = n;
                    n = cont;
                }
                for (int i = m; i<=n; i++)
                {
                    soma = soma + i;
                    Console.Write($"{i} ");
                }
                Console.WriteLine($"Sum={soma}");
                soma = 0;
            }
        }
    }
}
