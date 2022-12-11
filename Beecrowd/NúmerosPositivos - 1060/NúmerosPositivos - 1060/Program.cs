namespace NúmerosPositivos
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int positivo = 0;
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Digite o {i}° numero: ");
                double num = double.Parse(Console.ReadLine());
                if (num > 0)
                {
                    positivo++;
                }
            }
            Console.WriteLine($"{positivo} valores positivos");
        }
    }
}
