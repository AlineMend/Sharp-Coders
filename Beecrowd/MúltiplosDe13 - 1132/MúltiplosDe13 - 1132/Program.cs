namespace MúltiplosDe13
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int y = int.Parse(Console.ReadLine());
            int soma = 0;
            if (y > x)
            {
                int aux = y;
                y = x;
                x = aux;

            }
            for (int i = x; i >= y; i--)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);


        }
    }
}