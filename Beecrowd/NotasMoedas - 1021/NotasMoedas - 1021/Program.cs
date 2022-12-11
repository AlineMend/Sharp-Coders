using System.Text;

namespace NotasMoedas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um valor monetário: ");
            double valor = double.Parse(Console.ReadLine());
            double cem = (int)valor / 100;
            double troco1 = valor - (cem * 100);
            double cinquenta = (int)troco1 / 50;
            double troco2 = troco1 - (cinquenta * 50);
            double vinte = (int)troco2 / 20;
            double troco3 = troco2 - (vinte * 20);
            double dez = (int)troco3 / 10;
            double troco4 = troco3 - (dez * 10);
            double cinco = (int)troco4 / 5;
            double troco5 = troco4 - (cinco * 5);
            double dois = (int)troco5 / 2;
            double troco6 = troco5 - (dois * 2);
            double um = (int)troco6 / 1;
            double troco7 = (troco6 - (um * 1)) * 100;
            double cinquentaCentavos = (int) troco7 / 50;
            double troco8 = troco7 - (cinquentaCentavos * 50);
            double vinteCincoCentavos = (int) troco8 / 25;
            double troco9 = troco8 - (vinteCincoCentavos * 25);
            double dezCentavos = (int) troco9 / 10;
            double troco10 = troco9 - (dezCentavos * 10);
            double cincoCentavos = (int) troco10 / 5;
            double troco11 = troco10 - (cincoCentavos * 5);
            double umCentavo = (int) troco11 / 1;
            double troco12 = troco11 - (umCentavo * 1);
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{cem} nota(s) de R$ 100.00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50.00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20.00");
            Console.WriteLine($"{dez} nota(s) de R$ 10.00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5.00");
            Console.WriteLine($"{dois} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{um} moeda(s) de R$ 1.00");
            Console.WriteLine($"{cinquentaCentavos} moeda(s) de R$ 0.50");
            Console.WriteLine($"{vinteCincoCentavos} moeda(s) de R$ 0.25");
            Console.WriteLine($"{dezCentavos} moeda(s) de R$ 0.10");
            Console.WriteLine($"{cincoCentavos} moeda(s) de R$ 0.05");
            Console.WriteLine($"{umCentavo} moeda(s) de R$ 0.01");









        }
    }
}
