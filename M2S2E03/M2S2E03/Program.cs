internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome: ");
        string name = Console.ReadLine();

        Console.WriteLine("Digite a idade: ");
        int years = int.Parse(s: Console.ReadLine());

        Console.WriteLine(name);
        Console.WriteLine(years);
        if( years < 18)
        {
            Console.WriteLine("Menor de idade");
        }
        else if( years < 60)
        {
            Console.WriteLine("Maior de idade");
        }else
        {
            Console.WriteLine("Idoso");
        }
    }
}