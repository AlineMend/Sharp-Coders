namespace Cedulas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            int cem = valor / 100;
            int troco1 = valor - (cem * 100);
            int cinquenta = troco1 / 50;
            int troco2 = troco1 - (cinquenta * 50);
            int vinte = troco2/ 20;
            int troco3 = troco2 - (vinte* 20);
            int dez = troco3 / 10;
            int troco4 = troco3 - (dez * 10);
            int cinco = troco4 / 5;
            int troco5 = troco4 - (cinco * 5);
            int dois = troco5 / 2;
            int troco6 = troco5 - (dois * 2);
            Console.WriteLine(valor);
            Console.WriteLine($"{cem} nota(s) de R$ 100,00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
            Console.WriteLine($"{dez} nota(s) de R$ 10,00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
            Console.WriteLine($"{dois} nota(s) de R$ 2,00");
            Console.WriteLine($"{troco6} nota(s) de R$ 1,00");


        }
    }
}
