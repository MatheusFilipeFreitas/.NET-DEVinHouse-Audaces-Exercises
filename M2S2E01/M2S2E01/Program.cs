using M2S2E01;

internal class Program
{
    private static void Main(string[] args)
    {
        Methods method = new Methods();

        Console.WriteLine("Numero 1: ");
        int num1 = int.Parse(s: Console.ReadLine());

        Console.WriteLine("Numero 2: ");
        int num2 = int.Parse(s: Console.ReadLine());

        Console.WriteLine("Result: " + method.Sum(num1, num2));
    }
}