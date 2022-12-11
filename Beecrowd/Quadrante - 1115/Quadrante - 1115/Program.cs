namespace Quadrante
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j = 0;
            while (j == 0)
            {
                Console.Write("Digite as duas coordenadas: ");
                String[] linha = Console.ReadLine().Split(' ');
                int x = int.Parse(linha[0]);
                int y = int.Parse(linha[1]);
                if (x == 0 || y == 0)
                {
                    break;
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("segundo");
                }
            }
        }
    }
}