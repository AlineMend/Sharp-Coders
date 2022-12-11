namespace Multiplos
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.Write("Digite dois numeros: ");
            String[] linha = Console.ReadLine().Split(' ');
            int num1 = int.Parse(linha[0]);
            int num2 = int.Parse(linha[1]);
            if (num1 > num2 && num1 % num2 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if (num2 > num1 && num2 % num1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
                Console.WriteLine("Nao sao Multiplos");
        }
    }
}
