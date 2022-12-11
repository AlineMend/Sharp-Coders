namespace IdadeDias
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite sua idade em dias: ");
            int idade = int.Parse(Console.ReadLine());
            int ano = idade / 365;
            int mes = (idade % 365) / 30;
            int dia = (idade % 365) % 30;
            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }
    }
}
