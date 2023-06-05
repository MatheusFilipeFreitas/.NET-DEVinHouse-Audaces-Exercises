using Microsoft.AspNetCore.Mvc;
using movies_api.Models;

namespace movies_api.Controllers;

[Route("api/v{version:apiVersion}/filmes")]
[ApiVersion("1.0")]
[ApiController]
public class FilmesController
{
    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpGet]
    public IEnumerable<Filme> Get()
    {
        return MockFilmes.Filmes;
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Filme filme = MockFilmes.Filmes.FirstOrDefault( propertie => propertie.Id == id);

        if (filme is null)
        {
            return NotFound();
        }

        return Ok(filme);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    [HttpPost]
    public IActionResult Post([FromBody] Filme filme)
    {
        return CreatedAtAction(nameof(Get), new {id = filme.Id}, filme);
    }
    
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Filme value)
    {
        Filme filme = MockFilmes.Filmes.FirstOrDefault(propertie => propertie.Id == id);

        if (filme is null)
        {
            return NotFound();
        }

        var index = MockFilmes.Filmes.IndexOf(filme);

        if (index != -1)
        {
            MockFilmes.Filmes[index] = value;
        }
        
        return NoContent();
    }

    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        Filme filme = MockFilmes.Filmes.FirstOrDefault(propertie => propertie.Id == id);

        if (filme is null)
        {
            return NotFound();
        }
        
        MockFilmes.Filmes.Remove(filme);
        
        return NoContent();
    }
}