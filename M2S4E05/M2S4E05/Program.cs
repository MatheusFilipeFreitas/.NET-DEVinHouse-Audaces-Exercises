using M2S4E05;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Suki";
        pessoa.Idade = -15;
        Console.WriteLine(pessoa.Idade);
        pessoa.DefinirIdade(22);
        Console.WriteLine(pessoa.Idade);
    }
}