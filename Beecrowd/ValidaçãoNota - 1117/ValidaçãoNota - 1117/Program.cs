namespace ValidaçãoNota
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j = 0;
            double soma = 0;
            while (j >= 0 && j < 2)
            {
                Console.Write("Digite a nota do aluno:");
                double nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    soma = soma + nota;
                    j++;
                }
            }
            double media = soma / 2;
            Console.WriteLine($"media = {media.ToString("0.00")}");
        }
    }
}
