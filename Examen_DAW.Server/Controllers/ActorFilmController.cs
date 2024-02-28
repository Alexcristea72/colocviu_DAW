using Microsoft.AspNetCore.Mvc;
using Examen_DAW.Server.Interfaces;
using Examen_DAW.Server.Models;

[Route("api/[controller]")]
[ApiController]
public class ActorFilmController : ControllerBase
{
    private readonly IActorFilmRepository _actorFilmRepository;

    public ActorFilmController(IActorFilmRepository actorFilmRepository)
    {
        _actorFilmRepository = actorFilmRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetActorFilms()
    {
        var actorFilms = await _actorFilmRepository.GetActorFilmeAsync();
        return Ok(actorFilms);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetActorFilmById(int id)
    {
        var actorFilm = await _actorFilmRepository.GetActorFilmByIdAsync(id);

        if (actorFilm == null)
        {
            return NotFound();
        }

        return Ok(actorFilm);
    }

    [HttpPost]
    public async Task<IActionResult> AddActorFilm([FromBody] ActorFilm actorFilm)
    {
        await _actorFilmRepository.AddActorFilmAsync(actorFilm);
        return CreatedAtAction(nameof(GetActorFilmById), new { id = actorFilm.ActorFilmId }, actorFilm);
    }

}
