namespace SenhaFixa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j = 0;
            while (j == 0)
            {
                Console.Write("Digite a senha: ");
                int senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    j++;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}