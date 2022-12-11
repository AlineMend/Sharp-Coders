namespace Coordenadas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas de um ponto: ");
            String[] linha = Console.ReadLine().Split(' ');
            double x = double.Parse(linha[0]);
            double y = double.Parse(linha[1]);
            if ( x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Q3");
            }
        }
    }
}
