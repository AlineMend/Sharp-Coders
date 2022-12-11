namespace PositivosMédia
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int positivo = 0;
            double soma = 0;
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Digite o {i}° numero: ");
                double numero = double.Parse( Console.ReadLine() );
                if ( numero > 0 )
                {
                    positivo++;
                    soma = soma + numero;
                }
            }
            double media = soma / positivo;
            Console.WriteLine($"{positivo} valores positivos");
            Console.WriteLine(media.ToString("0.0"));
        }
    }
}
