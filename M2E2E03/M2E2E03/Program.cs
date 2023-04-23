using M2E2E03;

internal class Program
{
    private static void Main(string[] args)
    {
        Proprietario proprietario1 = new Proprietario("Teste", "123456789101","55999999999");
        Proprietario proprietario2 = new Proprietario("Teste2", "123456789101", "55999999999");
        Proprietario proprietario3 = new Proprietario("Teste3", "123456789101", "55999999999");
        List<Carro> carros = new List<Carro>();
        Carro carro1 =  new Carro("Carro", "Marca", "LLL9999", "Vermelho", proprietario1);
        Carro carro2 = new Carro("Carro2", "Marca2", "LLL9999", "Branco", proprietario2);
        Carro carro3 = new Carro("Carro3", "Marca3", "LLL9999", "Preto", proprietario3);

        carros.Add(carro1);
        carros.Add(carro2);
        carros.Add(carro3);
    }
}