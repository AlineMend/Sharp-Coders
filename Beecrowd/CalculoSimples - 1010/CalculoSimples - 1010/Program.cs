using System;
using System.Net.WebSockets;

namespace CalculoSimpls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o codigo, a quantidade e o valor unitario da peça 1: ");
            string[] linha1 = Console.ReadLine().Split(' '); 
            int codigo1 = int.Parse(linha1[0]);  
            int quant1 = int.Parse(linha1[1]);
            double valor1 = double.Parse(linha1[2]);
            Console.Write("Digite o codigo, a quantidade e o valor unitario da peça 2: ");
            string[] linha2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(linha2[0]);
            int quant2 = int.Parse(linha2[1]);
            double valor2 = double.Parse(linha2[2]);
            double total = (quant1 * valor1) + (quant2 * valor2);
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("0.00")}");
        }
    }
}
