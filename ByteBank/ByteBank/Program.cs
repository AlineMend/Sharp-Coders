using System.Linq;

namespace ByteBank
{
    public class Program
    {
        static void Menu()
        {
            Console.WriteLine("1 - Registrar novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Apresentar um usuário");
            Console.WriteLine("5 - Apresentar valor acumulado no banco");
            Console.WriteLine("6 - Manipular a conta");
            Console.WriteLine("0 - Para sair do programa");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o CPF: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.Write("Digite a senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
        }

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o CPF: ");
            string cpfParaDeletar = Console.ReadLine();
            int indexParaDeletar = cpfs.FindIndex(cpf => cpf == cpfParaDeletar);

            if (indexParaDeletar == -1)
            {
                Console.WriteLine("Não foi possível deletar esta Conta");
                Console.WriteLine("MOTIVO: Conta não encontrada.");
            }

            cpfs.Remove(cpfParaDeletar);
            titulares.RemoveAt(indexParaDeletar);
            senhas.RemoveAt(indexParaDeletar);
            saldos.RemoveAt(indexParaDeletar);

            Console.WriteLine("Conta deletada com sucesso");
        }
        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                ApresentaConta(i, cpfs, titulares, saldos);
            }
        }

        static void ApresentarUsuario(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Write("Digite o cpf: ");
            string cpfParaApresentar = Console.ReadLine();
            int indexParaApresentar = cpfs.FindIndex(cpf => cpf == cpfParaApresentar);

            if (indexParaApresentar == -1)
            {
                Console.WriteLine("Não foi possível apresentar esta Conta");
                Console.WriteLine("MOTIVO: Conta não encontrada.");
            }

            ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
        }

        static void ApresentarValorAcumulado(List<double> saldos)
        {
            Console.WriteLine($"Total acumulado no banco: {saldos.Sum()}");
            // saldos.Sum(); ou .Agregatte(0.0, (x, y) => x + y)
        }

        static void ApresentaConta(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine($"CPF = {cpfs[index]} | Titular = {titulares[index]} | Saldo = R${saldos[index]:F2}");
        }

        static void ManipularConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            int option;

            static void Login(List<string> cpfs, List<string> titulares, List<string> senhas)
            {
                Console.Write("Realize o Login! ");
                Console.WriteLine("------------------------");
                Console.Write("Digite o CPF: ");
                String cpfConta = Console.ReadLine();
                int indexConta = cpfs.FindIndex(cpf => cpf == cpfConta);
                if (indexConta == -1)
                {
                    Console.WriteLine("Não foi possível logar");
                    Console.WriteLine("MOTIVO: Usuario não encontrado.");
                    Login(cpfs, titulares, senhas);
                }
                else
                {
                    Console.Write("Digite a senha: ");
                    String senhaConta = Console.ReadLine();
                    if (senhas[indexConta] != senhaConta)
                    {
                        Console.WriteLine("Não foi possível logar");
                        Console.WriteLine("MOTIVO: Senha incorreta.");
                        Login(cpfs, titulares, senhas);
                    }

                    
                }
                Console.Clear();
                Console.WriteLine($"Bem Vindo(a) {titulares[indexConta]}!");
                Console.WriteLine();
            }
       
            static void Transferir(List<string> cpfs, List<double> saldos)
            {

                Console.Write("Digite o CPF da conta de origem:");
                string cpfContaOrigem = Console.ReadLine();
                int indexContaOrigem = cpfs.FindIndex(cpf => cpf == cpfContaOrigem);

                if (indexContaOrigem == -1)
                {
                    Console.WriteLine("Não foi possível transferir desta Conta");
                    Console.WriteLine("MOTIVO: Conta não encontrada.");
                }
                else
                {
                    Console.Write("Digite o CPF da conta de destino: ");
                    string cpfContaDestino = Console.ReadLine();
                    int indexContaDestino = cpfs.FindIndex(cpf => cpf == cpfContaDestino);
                    if (indexContaDestino == -1)
                    {
                        Console.WriteLine("Não foi possível transferir para esta Conta");
                        Console.WriteLine("MOTIVO: Conta não encontrada.");
                    }
                    else
                    {
                        Console.Write(" Digite o valor a ser transferido:");
                        double valorTrasferencia = double.Parse(Console.ReadLine());
                        if (valorTrasferencia > saldos[indexContaOrigem])
                        {
                            Console.WriteLine("Não foi possível transferir desta Conta");
                            Console.WriteLine("MOTIVO: Saldo insuficiente");
                        }
                        else
                        {
                            saldos[indexContaOrigem] -= valorTrasferencia;
                            saldos[indexContaDestino] += valorTrasferencia;
                            Console.Clear();
                            Console.WriteLine($"O novo saldo da conta de origem é R${saldos[indexContaOrigem]}");
                            Console.WriteLine($"O novo saldo da conta de destino é R${saldos[indexContaDestino]}");
                        }
                        
                    }
                    
                }

            }
            static void Sacar(List<string> cpfs, List<double> saldos)
            {

                Console.Write("Digite o CPF da conta: ");
                string cpfConta = Console.ReadLine();
                int indexConta = cpfs.FindIndex(cpf => cpf == cpfConta);

                if (indexConta == -1)
                {
                    Console.WriteLine("Não foi possível sacar desta Conta");
                    Console.WriteLine("MOTIVO: Conta não encontrada.");
                }
                else
                {
                    Console.Write("Digite o valor a ser sacado: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    if (valorSaque > saldos[indexConta])
                    {
                        Console.WriteLine("Não foi possível sacar desta Conta");
                        Console.WriteLine("MOTIVO: Saldo insuficiente");
                    }
                    else
                    {
                        saldos[indexConta] -= valorSaque;
                        Console.Clear();
                        Console.WriteLine($"O saldo da conta é R${saldos[indexConta]}");
                    }
                    
                }

            }
            static void Depositar(List<string> cpfs, List<double> saldos)
            {

                Console.Write("Digite o CPF da conta: ");
                string cpfConta = Console.ReadLine();
                int indexConta = cpfs.FindIndex(cpf => cpf == cpfConta);

                if (indexConta == -1)
                {
                    Console.WriteLine("Não foi possível depositar nesta Conta");
                    Console.WriteLine("MOTIVO: Conta não encontrada.");
                }
                else
                {
                    Console.Write("Digite o valor a ser depositado: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    saldos[indexConta] += valorDeposito;
                    Console.Clear();
                    Console.WriteLine($"O saldo da conta é R${saldos[indexConta]}");

                }

            }
            static void Opcao()
            {
                Console.WriteLine("1 - Trasnferir");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("0 - Para sair do programa");
                Console.WriteLine();
                Console.Write("Digite a opção desejada: ");
            }

            Login(cpfs, titulares, senhas);
            do
            {
                Opcao();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Estou encerrando o programa...");
                        break;
                    case 1:
                        Transferir(cpfs, saldos);
                        break;
                    case 2:
                        Sacar(cpfs, saldos);
                        break;
                    case 3:
                        Depositar(cpfs, saldos);
                        break;
                }

                Console.WriteLine("-----------------");

            } while (option != 0);

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo(a) ao Byte Bank! ");
            Console.WriteLine();

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

            int option;

            do
            {
                Menu();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Estou encerrando o programa...");
                        break;
                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 2:
                        DeletarUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        ApresentarUsuario(cpfs, titulares, saldos);
                        break;
                    case 5:
                        ApresentarValorAcumulado(saldos);
                        break;
                    case 6:
                        ManipularConta(cpfs, titulares, senhas, saldos);
                        break;
                }

                Console.WriteLine("-----------------");

            } while (option != 0);

        }
    }
}
