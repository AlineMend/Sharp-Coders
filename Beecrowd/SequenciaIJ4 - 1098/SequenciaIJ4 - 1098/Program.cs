namespace SequenciaIJ4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double i = 0;
            double j = 1;
            while (i <= 2)
            {
                for (int k = 1; k <= 3; k++)
                {
                    if (i == 0.0 || i == 1.0 || i > 1.8)
                    {
                        Console.WriteLine($"I={i.ToString("0")} J={j.ToString("0")}");
                    }
                    else
                    {
                        Console.WriteLine($"I={i.ToString("0.0")} J={j.ToString("0.0")}");
                    }
                    j++;
                }
                i += 0.2;
                j  = 1 + i;
            }
        }
    }
}
