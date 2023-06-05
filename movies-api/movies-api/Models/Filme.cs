namespace movies_api.Models;

public class Filme
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public string Diretor { get; set; }
    public string Genero { get; set; }
}