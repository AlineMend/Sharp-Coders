namespace Experiências
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de casos de teste: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            int r = 0;
            int s = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite a quantidade (de 1 a 15) a o tipo (R:Rato S:Sapo C:Coelho): ");
                String[] linha = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(linha[0]);
                string tipo = linha[1];
                if (tipo.Equals("R"))
                {
                    r = r + quantidade;
                }
                else if (tipo.Equals("S"))
                {
                    s = s + quantidade;
                }
                else
                {
                    c= c + quantidade;
                }
                soma = soma + quantidade;
            }
            double porR = (100 * r) / (double)soma;
            double porS = (100 * s) / (double)soma;
            double porC = (100 * c) / (double)soma;
            Console.WriteLine($"Total: {soma} cobaias");
            Console.WriteLine($"Total de coelhos: {c}");
            Console.WriteLine($"Total de ratos: {r}");
            Console.WriteLine($"Total de sapos: {s}");
            Console.WriteLine($"Percentual de coelhos: {porC.ToString("0.00")} %");
            Console.WriteLine($"Percentual de ratos: {porR.ToString("0.00")} %");
            Console.WriteLine($"Percentual de sapos: {porS.ToString("0.00")} %");
        }
    }
}
