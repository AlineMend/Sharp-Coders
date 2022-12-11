namespace SequenciaIJ1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j = 65;
            int i = -2;
            while (j >= 5)
            {
                j = j - 5;
                i = i + 3;
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}