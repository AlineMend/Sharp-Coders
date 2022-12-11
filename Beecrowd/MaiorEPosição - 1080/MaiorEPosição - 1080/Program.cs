namespace MaiorEPosição
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maior = 0;
            int posição = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("Digite um numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posição = i;
                }

            }
            Console.WriteLine(maior);
            Console.WriteLine(posição);
        }
    }
}