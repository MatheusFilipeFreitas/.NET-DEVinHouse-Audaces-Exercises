using M2S4E03;

internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cliente = new Cliente("Joao Silva", "123.456.789-00");
        ContaBancaria contaBancaria = new ContaBancaria("0001152", cliente);


        Console.WriteLine("Dados da conta:");
        Console.WriteLine(contaBancaria.ExibirDados());

        contaBancaria.Depositar(1000.00);
        Console.WriteLine("Deposito... 1000,00");

        Console.WriteLine(contaBancaria.ToString());

        contaBancaria.Sacar(500.00);
        Console.WriteLine("Saque... 500,00");

        Console.WriteLine(contaBancaria.ToString());
    }
}