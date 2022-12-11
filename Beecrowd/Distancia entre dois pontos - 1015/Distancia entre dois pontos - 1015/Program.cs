using System;
using System.Globalization;

namespace DistanciaDoisPontos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            double x1, x2, y1, y2, distancia;
            string[] valores;
            Console.Write(" Digite o eixo X e Y do primeiro ponto: ");
            valores = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            Console.Write(" Digite o eixo X e Y do segundo ponto: ");
            valores = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x1 - x2, 2.00) + Math.Pow(y1 - y2, 2.00));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
