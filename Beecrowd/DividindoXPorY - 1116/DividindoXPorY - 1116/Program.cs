namespace DividindoXPorY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de pares: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite dois numeros: ");
                string[] linha = Console.ReadLine().Split(' ');
                int x = int.Parse(linha[0]);
                int y= int.Parse(linha[1]);
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double) x / y;
                    Console.WriteLine(div.ToString("0.0"));
                }

            }
        }
    }
}
