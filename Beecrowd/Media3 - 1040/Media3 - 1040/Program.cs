namespace Media3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite as quatro notas do aluno: ");
            String[] linha = Console.ReadLine().Split(' ');
            double nota1 = double.Parse(linha[0]);
            double nota2 = double.Parse(linha[1]);
            double nota3 = double.Parse(linha[2]);
            double nota4 = double.Parse(linha[3]);
            double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 10;
            media = Math.Round(media,1);
            Console.WriteLine($"Media: {media.ToString("0.0")}");
            if ( media >= 5 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                Console.Write("Digite a nota do exame: ");
                double notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaExame.ToString("0.0")}");
                double media2 = (notaExame + media) / 2;
                if (media2 >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {media2.ToString("0.0")}");
                return;
            }
            else if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
