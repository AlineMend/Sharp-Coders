namespace TiposDeTriangulos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores: ");
            String[] linha = Console.ReadLine().Split(' ');
            double num1 = double.Parse(linha[0]);
            double num2 = double.Parse(linha[1]);
            double num3 = double.Parse(linha[2]);


            if (num2> num1 && num2 > num3)
            {
                double cont = num1;
                num1 = num2;
                num2 = cont;
            }
            else if (num3 > num1)
            {
                double cont = num1;
                num1 = num3;
                num3 = cont;
            }
            if (num1 >= num2 + num3) 
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (num1 * num1 == (num2 * num2) + (num3 * num3)) Console.WriteLine("TRIANGULO RETANGULO");
                if (num1 * num1 > (num2 * num2) + (num3 * num3)) Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (num1 * num1 < (num2 * num2) + (num3 * num3)) Console.WriteLine("TRIANGULO ACUTANGULO");
                if (num1 == num2 && num1 == num3) Console.WriteLine("TRIANGULO EQUILATERO");
                if ((num1 == num2 && num1 != num3) || (num1 == num3 && num1 != num2) || (num2 == num3 && num2 != num1)) Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
