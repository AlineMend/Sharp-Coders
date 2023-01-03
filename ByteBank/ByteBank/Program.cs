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
            Console.Write("Digite a opção desejada: ");
        }

        static void RegistrarNovoUsuario (List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o CPF: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.Write("Digite a senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
        }

        static  void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
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

        static void ManipularConta((List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            static void Menu2()
            {
                Console.WriteLine("1 - Trasnferir");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("0 - Para sair do programa");
                Console.Write("Digite a opção desejada: ");
            }
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
                        Transferir();
                        break;
                    case 2:
                        Sacar();
                        break;
                    case 3:
                        Depositar();
                        break;
                }

                Console.WriteLine("-----------------");

            } while (option != 0);

            static void Transferir()
            {

                Console.Write("Digite o CPF da conta de origem:");
                int indiceContaOrigem = int.Parse(Console.ReadLine());

                Console.Write("Digite o CPF da conta de destino: ");
                int indiceContaDestino = int.Parse(Console.ReadLine());

                Console.Write(" Digite o valor a ser transferido:");
                double valorTrasferencia = double.Parse(Console.ReadLine());

            }
            static void Sacar()
            {

                Console.Write("Digite o CPF da conta: ");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser sacado: ");
                double valorSaque = double.Parse(Console.ReadLine());

            }
            static void Depositar()
            {

                Console.Write("Digite o CPF da conta: ");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser depositado: ");
                double valorDeposito = double.Parse(Console.ReadLine());

            }

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Antes de começar a usar, vamos configurar alguns valores: ");

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
                        ManipularConta(cpfs, titulares, senhas, saldos);
                        break;
                }

                Console.WriteLine("-----------------");

            } while (option != 0);

        }
    }
