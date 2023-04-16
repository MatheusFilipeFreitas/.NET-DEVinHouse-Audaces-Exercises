internal class Program
{
    private static void Main(string[] args)
    {
        Boolean loop = true;

        while (loop)
        {
            Console.WriteLine("Digite um numero: ");
            int num = int.Parse(s: Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Erro: numero nao pode ser 0!");
            }
            else if (num < 0)
            {
                Console.WriteLine("Erro: numero nao pode ser negativo!");
            }
            else
            {
                loop = false;
                Console.WriteLine("Resultado:");
                for (int i = 0; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}