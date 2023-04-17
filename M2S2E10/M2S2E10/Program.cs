using M2S2E10;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        Boolean loop = true;

        while(loop)
        {
            loop = calc.Menu();
        }
        
    }
}