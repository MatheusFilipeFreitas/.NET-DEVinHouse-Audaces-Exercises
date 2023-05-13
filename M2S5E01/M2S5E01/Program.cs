using M2S5E01.Interface;
using M2S5E01.service;

internal class Program
{
    private static void Main(string[] args)
    {
        IClienteService clienteService = new ClienteService();

        string opcao;
        do
        {
            Console.WriteLine("\n\nBem Vindo ao banco Fullstack, Escolha uma opção para continuar: ");
            Console.WriteLine("1 - Abrir Conta");
            Console.WriteLine("2 - Consultar Conta");
            Console.WriteLine("3 - Listar Todas as contas");
            Console.WriteLine("4 - Sair\n");
            opcao = Console.ReadLine();
            SelecaoMenu(opcao);
        } while (opcao != "4");



        void SelecaoMenu(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    clienteService.CriarConta();
                    break;
                case "2":
                    Console.WriteLine("Digite o Numero da conta:");
                    string numeroConta = Console.ReadLine();
                    var cliente = clienteService.BuscarClientePorConta(numeroConta);
                    if (cliente == null)
                    {
                        Console.WriteLine("Conta não Cadastrada");
                    }
                    else
                    {
                        Console.WriteLine(cliente.ResumoCliente());
                    }
                    break;
                case "3":
                    clienteService.ListarClientes();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

    }
}