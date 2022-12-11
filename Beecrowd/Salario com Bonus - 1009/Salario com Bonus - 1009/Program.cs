namespace SalarioBonus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o nome do vendedor: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o valor do salario fixo do vendedor: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o total de vendas do vendedor: ");
            double vendas = double.Parse(Console.ReadLine());
            double total = salario + vendas * 0.15;
            Console.WriteLine($"TOTAL = R$ {total.ToString("0.00")}");
        }
    }
}
