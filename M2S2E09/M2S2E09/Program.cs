internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade: ");
        int length = int.Parse(Console.ReadLine());

        float[] numbers = new float[length];
        float sum = 0;

        for(int i = 0; i < length; i++)
        {
            Console.WriteLine("Digite o numero: ");
            float num = float.Parse(Console.ReadLine());

            numbers[i] = num;
        }

        foreach(float num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("Result: " + (sum /= length));
    }
}