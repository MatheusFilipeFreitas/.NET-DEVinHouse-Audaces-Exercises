using M2E2E03;

internal class Program
{
    private static void Main(string[] args)
    {
        Program pr = new Program();
        List<Proprietario> proprietarios = new List<Proprietario>();
        Proprietario proprietario1 = new Proprietario("Teste", "123456789101","55999999999");
        Proprietario proprietario2 = new Proprietario("Teste2", "123456789101", "55999999999");
        Proprietario proprietario3 = new Proprietario("Teste3", "123456789101", "55999999999");

        proprietarios.Add(proprietario1);
        proprietarios.Add(proprietario2);
        proprietarios.Add(proprietario3);

        List<Carro> carros = new List<Carro>();
        Carro carro1 =  new Carro("Carro", "Marca", "LLL9999", "Vermelho", proprietario1);
        Carro carro2 = new Carro("Carro2", "Marca2", "LLL9999", "Branco", proprietario2);
        Carro carro3 = new Carro("Carro3", "Marca3", "LLL9999", "Preto", proprietario3);

        carros.Add(carro1);
        carros.Add(carro2);
        carros.Add(carro3);

        Console.WriteLine(proprietarios.Count);

        pr.AddCarros(proprietarios);
    }

    public void AddCarros(List<Proprietario> proprietarios)
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

        Console.WriteLine("Carro adicionado a lista!");
    }

}