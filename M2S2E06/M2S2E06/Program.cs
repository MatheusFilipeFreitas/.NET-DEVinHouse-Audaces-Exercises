
internal class Program
{
    private static void Main(string[] args)
    {
        string phrase = "A linguagem de programação C# é muito poderosa";
        string[] words = phrase.Split(" ");

        foreach (string word in words)
        {
            if(word.Equals("poderosa"))
            {
                Console.WriteLine(word);
            }
        }
    }
}