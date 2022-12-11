namespace Animal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("O animal é vertebrado ou invertebrado? ");
            string tipo1 = Console.ReadLine();
            Console.Write("O animal é ave, mamifero, inseto ou anelideo? ");
            string tipo2 = Console.ReadLine();
            Console.Write("O animal é carnivoro, onivoro, herbivoro ou hematofago? ");
            string tipo3 = Console.ReadLine();
            if (tipo1.Equals("vertebrado"))
            {
                if (tipo2.Equals("ave"))
                {
                    if (tipo3.Equals("carnivoro"))
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (tipo3.Equals("onivoro"))
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (tipo2.Equals("inseto"))
                {
                    if (tipo3.Equals("hematofago"))
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (tipo3.Equals("hematofago"))
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}