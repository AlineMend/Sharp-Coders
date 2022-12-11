namespace SeisNúmerosÍmpares
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            int cont = 0;
            while (cont < 6) 
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                    cont++;
                }
                numero++;
            }
        }
    }
}
