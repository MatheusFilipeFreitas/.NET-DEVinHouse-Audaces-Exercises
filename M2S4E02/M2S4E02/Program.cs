using M2S4E02;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria("0002830", 1000.0);
        Console.WriteLine(value: $"Conta criada... Saldo: {conta.GetSaldo()}");
        conta.Deposita(500);
        conta.Saca(2000);
        Console.WriteLine(value: $"Saldo: {conta.GetSaldo()}");
        conta.Deposita(100);
        conta.Saca(2000);
        Console.WriteLine(value: $"Saldo: {conta.GetSaldo()}");
        conta.Saca(1600);
        Console.WriteLine(value: $"Saldo: {conta.GetSaldo()}");
        conta.Saca(200);
        Console.WriteLine(value: $"Saldo: {conta.GetSaldo()}");
    }
}