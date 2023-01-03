namespace QuadradoMágico
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int[] somaLinha = new int[n];
            int[] somaColuna = new int[n];
            int diagonal = 0;
            int diagonalSecundaria = 0;
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {

                    matriz[linha, coluna] = int.Parse(Console.ReadLine());

                }

            }

            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < n; coluna++)
                {

                    somaLinha[linha] += matriz[linha, coluna];

                }

            }

            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < n; coluna++)
                {

                    somaColuna[coluna] += matriz[linha, coluna];

                }

            }

            for (int linha = 0; linha < n; linha++)
            {
                diagonal += matriz[linha, linha];
            }

            for (int linha = 0; linha < n; linha++)
            {
                diagonalSecundaria += matriz[linha, (n-linha-1)];
            }

            int testaL = 1;
            int testaC = 1;
            for (int i = 1; i < n; i++)
            {
                if (somaLinha[i] != somaLinha[i - 1])
                {
                    testaL = 0;
                    break;
                }
                else if (somaColuna[i] != somaColuna[i - 1])
                {
                    testaC = 0;
                    break;
                }
            }

            if (testaL && testaC && diagonal == diagonalSecundaria && diagonal == somaLinha[0])
            {
                Console.WriteLine(diagonal);
            }
            else
            {
                Console.WriteLine("0"); ;
            }
        }
    }
}
