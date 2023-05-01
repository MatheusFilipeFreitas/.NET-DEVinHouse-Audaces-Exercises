using M2E4E04;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria contaBancaria = new ContaBancaria(-500.00);
        Console.WriteLine(contaBancaria.Saldo.ToString("C"));
        contaBancaria.Depositar(300.00);
        Console.WriteLine(contaBancaria.Saldo.ToString("C"));
        Console.WriteLine(contaBancaria.Sacar(200.00));
        Console.WriteLine(contaBancaria.Saldo.ToString("C"));
    }
}