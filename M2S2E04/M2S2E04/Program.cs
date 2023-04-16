using M2S2E04;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome: ");
        string name = Console.ReadLine();

        Console.WriteLine("Digite o modelo: ");
        string model = Console.ReadLine();

        Console.WriteLine("Km rodados: ");
        float km = float.Parse(s: Console.ReadLine());

        Car car = new Car(name, model, km);

        Console.WriteLine(car.Info());
    }
}