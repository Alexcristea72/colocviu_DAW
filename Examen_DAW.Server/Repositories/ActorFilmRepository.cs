using Examen_DAW.Server.Interfaces;
using Examen_DAW.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ActorFilmRepository : IActorFilmRepository
{
    private readonly AppDbContext _context;

    public ActorFilmRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<ActorFilm>> GetActorFilmeAsync()
    {
        return await _context.ActorFilme.ToListAsync();
    }

    public async Task<ActorFilm> GetActorFilmByIdAsync(int actorFilmId)
    {
        return await _context.ActorFilme.FirstOrDefaultAsync(af => af.ActorFilmId == actorFilmId);
    }

    public async Task AddActorFilmAsync(ActorFilm actorFilm)
    {
        _context.ActorFilme.Add(actorFilm);
        await _context.SaveChangesAsync();
    }

}
