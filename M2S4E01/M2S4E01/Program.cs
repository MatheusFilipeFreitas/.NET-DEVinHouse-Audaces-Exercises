using M2S4E01;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Bian",23,"Seol");
        Console.WriteLine(pessoa.Saudacao());
    }
}