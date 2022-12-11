namespace SequenciaIJ3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            int j = 7;
            while (i <= 9)
            {
                for (int k = 1; k < 4; k++)
                {
                    Console.WriteLine($"I={i} J={j}");
                    j--;
                }
                i += 2;
                j += 5;
            }
        }
    }
}
