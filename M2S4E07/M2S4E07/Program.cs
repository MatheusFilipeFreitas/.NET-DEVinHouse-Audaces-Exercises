using M2S4E07;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Saldo = 100;
        conta.Depositar(1500);
        Console.WriteLine(value: $"{conta.Saldo}");
        conta.Sacar(500);
        Console.WriteLine(value: $"{conta.Saldo}");
    }
}