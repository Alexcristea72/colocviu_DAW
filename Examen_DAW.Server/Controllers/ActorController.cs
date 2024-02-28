using Microsoft.AspNetCore.Mvc;
using Examen_DAW.Server.Interfaces;
using Examen_DAW.Server.Models;

[Route("api/[controller]")]
[ApiController]
public class ActorController : ControllerBase
{
    private readonly IActorRepository _actorRepository;

    public ActorController(IActorRepository actorRepository)
    {
        _actorRepository = actorRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetActors()
    {
        var actors = await _actorRepository.GetActoriiAsync();
        return Ok(actors);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetActorById(int id)
    {
        var actor = await _actorRepository.GetActorByIdAsync(id);

        if (actor == null)
        {
            return NotFound();
        }

        return Ok(actor);
    }

    [HttpPost]
    public async Task<IActionResult> AddActor([FromBody] Actor actor)
    {
        await _actorRepository.AddActorAsync(actor);
        return CreatedAtAction(nameof(GetActorById), new { id = actor.ActorId }, actor);
    }

}
