using Microsoft.AspNetCore.Mvc;
using Examen_DAW.Server.Interfaces;
using Examen_DAW.Server.Models;

[Route("api/[controller]")]
[ApiController]
public class FilmController : ControllerBase
{
    private readonly IFilmRepository _filmRepository;

    public FilmController(IFilmRepository filmRepository)
    {
        _filmRepository = filmRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetFilms()
    {
        var films = await _filmRepository.GetFilmeAsync();
        return Ok(films);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFilmById(int id)
    {
        var film = await _filmRepository.GetFilmByIdAsync(id);

        if (film == null)
        {
            return NotFound();
        }

        return Ok(film);
    }

    [HttpPost]
    public async Task<IActionResult> AddFilm([FromBody] Film film)
    {
        await _filmRepository.AddFilmAsync(film);
        return CreatedAtAction(nameof(GetFilmById), new { id = film.FilmId }, film);
    }

}
