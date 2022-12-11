namespace AumentoDeSalário
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor do salario: ");
            double salarioAtual = double.Parse(Console.ReadLine());
            int faixa1 = 15;
            int faixa2 = 12;
            int faixa3 = 10;
            int faixa4 = 7;
            int faixa5 = 4;
            if (salarioAtual <= 400)
            {
                double reajuste = (salarioAtual * faixa1) / 100;
                double salarioNovo = salarioAtual + reajuste;
                Console.WriteLine($"Novo salario: {salarioNovo.ToString("0.00")}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("0.00")}");
                Console.WriteLine($"Em percentual: {faixa1} %");
            }
            else if (salarioAtual > 400 && salarioAtual <= 800)
            {
                double reajuste = (salarioAtual * faixa2) / 100;
                double salarioNovo = salarioAtual + reajuste;
                Console.WriteLine($"Novo salario: {salarioNovo.ToString("0.00")}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("0.00")}");
                Console.WriteLine($"Em percentual: {faixa2} %");
            }
            else if (salarioAtual > 800 && salarioAtual <= 1200)
            {
                double reajuste = (salarioAtual * faixa3) / 100;
                double salarioNovo = salarioAtual + reajuste;
                Console.WriteLine($"Novo salario: {salarioNovo.ToString("0.00")}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("0.00")}");
                Console.WriteLine($"Em percentual: {faixa3} %");
            }
            else if (salarioAtual > 1200 && salarioAtual <= 2000)
            {
                double reajuste = (salarioAtual * faixa4) /100;
                double salarioNovo = salarioAtual + reajuste;
                Console.WriteLine($"Novo salario: {salarioNovo.ToString("0.00")}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("0.00")}");
                Console.WriteLine($"Em percentual: {faixa4} %");
            }
            else
            {
                double reajuste = (salarioAtual * faixa5) /100;
                double salarioNovo = salarioAtual + reajuste;
                Console.WriteLine($"Novo salario: {salarioNovo.ToString("0.00")}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("0.00")}");
                Console.WriteLine($"Em percentual: {faixa5} %");
            }
        }
    }
}
