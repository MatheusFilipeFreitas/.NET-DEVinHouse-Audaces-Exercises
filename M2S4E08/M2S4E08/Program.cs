using M2S4E08;

internal class Program
{
    private static void Main(string[] args)
    {
        Gato gato = new Gato();
        gato.EmitirSom();

        Cachorro  cachorro = new Cachorro();
        cachorro.EmitirSom();
    }
}