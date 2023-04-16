using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList nums = new ArrayList ();

        for(int i = 0; i < 4; i++)
        {
            Console.WriteLine("Numero " + (i + 1) + ":" );
            int num = int.Parse(s: Console.ReadLine());
            nums.Add (num);
        }

        nums.Sort();
        Console.WriteLine();
        foreach(int element in nums)
        {
            Console.Write(element + " ");
        }
    }
}