namespace ImpostoDeRenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor do salario: ");
            double salario = double.Parse(Console.ReadLine());
            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000 && salario <= 3000)
            {
                double imposto = (salario - 2000) * 0.08;
                Console.WriteLine($"R$ {imposto.ToString("0.00")}");
            }
            else if (salario > 3000 && salario <= 4500)
            {
                double imposto = ((salario - 3000) * 0.18) + 80;
                Console.WriteLine($"R$ {imposto.ToString("0.00")}");
            }
            else
            {
                double imposto = ((salario - 4500) * 0.28) + 350;
                Console.WriteLine($"R$ {imposto.ToString("0.00")}");
            }
        }
    }
}