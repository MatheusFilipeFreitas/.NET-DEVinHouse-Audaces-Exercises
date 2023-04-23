using M2E2E03;

internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();
        List<Proprietario> proprietarios = new List<Proprietario>();
        List<Carro> carros = new List<Carro>();

        program.InicializeData(proprietarios, carros);
        program.Menu(proprietarios, carros);
    }

    public void AddCarros(List<Proprietario> proprietarios, List<Carro> carros)
    {
        Carro newCarroToAdd = new Carro();
        Console.WriteLine("Modelo: ");
        string modelo = Console.ReadLine();

        Console.WriteLine("Marca: ");
        string marca = Console.ReadLine();

        Console.WriteLine("Placa: ");
        string placa = Console.ReadLine();

        Console.WriteLine("Cor: ");
        string cor = Console.ReadLine();

        Console.WriteLine("Proprietario: ");
        for(int i = 0; i < proprietarios.Count;  i++)
        {
            Console.WriteLine((i+1) + ") " + proprietarios[i].nome);
        }
        int optionProprietario = int.Parse(Console.ReadLine());

        newCarroToAdd.modelo = modelo;
        newCarroToAdd.marca = marca;
        newCarroToAdd.placa = placa;
        newCarroToAdd.cor = cor;
        newCarroToAdd.proprietario = proprietarios[optionProprietario - 1];

        carros.Add(newCarroToAdd);
        Console.WriteLine("Carro adicionado a lista!");
    }

    public void ListCarros(List<Carro> carros)
    {
        foreach(Carro carro in carros)
        {
            Console.WriteLine("----");
            Console.WriteLine("Modelo: " + carro.modelo);
            Console.WriteLine("Marca: " + carro.marca);
            Console.WriteLine("Placa: " + carro.placa);
            Console.WriteLine("Cor: " + carro.cor);
            Console.WriteLine("Nome Proprietario: " + carro.proprietario.nome);
            Console.WriteLine("CPF Proprietario: " + carro.proprietario.cpf);
            Console.WriteLine("Telefone Proprietario: " + carro.proprietario.telefone);
            Console.WriteLine("----");
        }
    }

    public void Menu(List<Proprietario> proprietarios, List<Carro> carros)
    {
        Program program = new Program();
        int option = 0;

        do
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("1-Cadastrar Carro");
            Console.WriteLine("2-Consultar Carros");
            Console.WriteLine("3-Sair");

            if(int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        program.AddCarros(proprietarios, carros);
                        break;

                    case 2:
                        program.ListCarros(carros);
                        break;

                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Digite um numero inteiro segundo as opcoes!");
            }

        } while (option != 3);
    }

    public void InicializeData(List<Proprietario> proprietarios, List<Carro> carros)
    {
        
        Proprietario proprietario1 = new Proprietario("Teste", "123456789101", "55999999999");
        Proprietario proprietario2 = new Proprietario("Teste2", "123456789101", "55999999999");
        Proprietario proprietario3 = new Proprietario("Teste3", "123456789101", "55999999999");

        proprietarios.Add(proprietario1);
        proprietarios.Add(proprietario2);
        proprietarios.Add(proprietario3);

        
        Carro carro1 = new Carro("Carro", "Marca", "LLL9999", "Vermelho", proprietario1);
        Carro carro2 = new Carro("Carro2", "Marca2", "LLL9999", "Branco", proprietario2);
        Carro carro3 = new Carro("Carro3", "Marca3", "LLL9999", "Preto", proprietario3);

        carros.Add(carro1);
        carros.Add(carro2);
        carros.Add(carro3);
    }

}