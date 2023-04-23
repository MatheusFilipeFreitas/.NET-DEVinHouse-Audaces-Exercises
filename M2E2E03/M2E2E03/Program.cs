using M2E2E03;

internal class Program
{
    private static void Main(string[] args)
    {
        Proprietario proprietario1 = new Proprietario("Teste", "123456789101","55999999999");
        Proprietario proprietario2 = new Proprietario("Teste2", "123456789101", "55999999999");
        Proprietario proprietario3 = new Proprietario("Teste3", "123456789101", "55999999999");
        Carro carro1 =  new Carro("Carro", "Marca", "LLL9999", "Vermelho", proprietario1);
        Carro carro2 = new Carro("Carro2", "Marca2", "LLL9999", "Branco", proprietario2);
        Carro carro3 = new Carro("Carro3", "Marca3", "LLL9999", "Preto", proprietario3);
    }
}