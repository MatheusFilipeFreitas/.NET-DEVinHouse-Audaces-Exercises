using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[5];
        
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Numero " + (i+1) + ": ");
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }

        Array.Sort(numbers);
        Array.Reverse(numbers);

        foreach(int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}