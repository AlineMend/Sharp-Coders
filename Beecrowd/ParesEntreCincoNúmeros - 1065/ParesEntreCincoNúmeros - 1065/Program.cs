namespace ParesEntreCincoNúmeros
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int pares = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o {i}° numero: ");
                int numero = int.Parse( Console.ReadLine() );
                if (numero % 2 == 0)
                {
                    pares++;
                }
            }
            Console.WriteLine($"{pares} valores pares");
        }
    }
}
