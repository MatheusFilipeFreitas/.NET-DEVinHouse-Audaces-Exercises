using M2S2E02;

internal class Program
{
    private static void Main(string[] args)
    {
        Methods method = new Methods();
        Console.WriteLine("Numero: ");
        int num = int.Parse(s: Console.ReadLine());
        if(method.isOdd(num))
        {
            Console.WriteLine("Odd");
        }
        else
        {
            Console.WriteLine("Even");
        }
    }
}