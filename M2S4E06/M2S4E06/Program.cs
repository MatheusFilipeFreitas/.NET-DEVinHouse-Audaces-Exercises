using M2S4E06;

internal class Program
{
    private static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        retangulo.Altura = 15;
        retangulo.Largura = -10;

        Console.WriteLine(retangulo.Altura);
        Console.WriteLine(retangulo.Largura);

        retangulo.Largura = 20;
        Console.WriteLine(retangulo.CalculaArea().ToString());
    }
}