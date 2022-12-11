namespace TempoDeJogoComMinutos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial, minuto inicial, hora final e minuto final do jogo");
            String[] linha = Console.ReadLine().Split(' ');
            int hInicio = int.Parse(linha[0]);
            int mInicio = int.Parse(linha[1]);
            int hFim = int.Parse(linha[2]);
            int mFim = int.Parse(linha[3]);
            int mTotal = mFim - mInicio;
            int hTotal = hFim - hInicio;
            if (hTotal <= 0 && mTotal <= 0)
            {
                hTotal += 24;

            }
            if (mTotal < 0)
            {
                mTotal += 60;
                hTotal--;
            }
            Console.WriteLine($"O JOGO DUROU {hTotal} HORA(S) E {mTotal} MINUTO(S)");
            
        }
    }
}
