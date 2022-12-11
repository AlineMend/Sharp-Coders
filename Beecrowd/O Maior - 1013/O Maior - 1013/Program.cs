using System.Text.RegularExpressions;

namespace Omaior
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite três numeros: ");
            string[] maior = Console.ReadLine().Split(' ');
            int A = int.Parse(maior[0]);
            int B = int.Parse(maior[1]);
            int C = int.Parse(maior[2]);
            int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            int MaiorC = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine(MaiorC + " eh o maior");
        }
    }
}
