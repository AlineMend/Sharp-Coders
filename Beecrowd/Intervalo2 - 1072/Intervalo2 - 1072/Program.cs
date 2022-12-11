namespace Intervalo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número de casos de teste: ");
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero >= 10 && numero <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}