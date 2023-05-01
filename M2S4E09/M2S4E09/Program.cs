using M2S4E09;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(value: $"{Calculadora.Somar(5, 15)}");
        Console.WriteLine(value: $"{Calculadora.Multiplicacao(5, 15)}");
        Console.WriteLine(value: $"{Calculadora.Divisao(5, 15)}");
        Console.WriteLine(value: $"{Calculadora.Subtracao(5, 15)}");
        Console.WriteLine(value: $"{Calculadora.Somar(1, Calculadora.Pi)}");
    }
}