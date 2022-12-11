namespace Salario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de registro do funcionario: ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas do funcionario: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor recebido por hora: ");
            double valor = double.Parse(Console.ReadLine());
            double salario = horas * valor;
            Console.WriteLine($"NUMBER = {ID}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("0.00")}");

        }
    }
}