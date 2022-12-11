namespace SortSimples
{
    public class Program
    {
        public  static void Main(string[] args)
        {
            Console.Write("Digite três numeros: ");
            String[] linha = Console.ReadLine().Split(' ');
            int num1 = int.Parse(linha[0]);
            int num2 = int.Parse(linha[1]);
            int num3 = int.Parse(linha[2]);

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1);
                if (num2 < num3)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }
            else if (num2 < num3)
            {
                Console.WriteLine(num2);
                if (num1 < num3)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
                else 
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                }
            }
            else
            {
                Console.WriteLine(num3);
                if (num1 < num2)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
            }
            Console.WriteLine("");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
