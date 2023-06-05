using Microsoft.AspNetCore.Mvc;
using movies_api.Models;

namespace movies_api.Controllers;

[Route("api/v0/filmes")]
[ApiController]
public class FilmesController
{
    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpGet]
    public IEnumerable<Filme> Get()
    {
        return null;
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return null;
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    [HttpPost]
    public IActionResult Post([FromBody] Filme filme)
    {
        return null;
    }
    
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Filme filme)
    {
        return null;
    }

    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return null;
    }
}