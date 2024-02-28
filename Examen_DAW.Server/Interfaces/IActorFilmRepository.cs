// Examen_DAW.Server/Interfaces/IActorFilmRepository.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using Examen_DAW.Server.Models;

namespace Examen_DAW.Server.Interfaces
{
    public interface IActorFilmRepository
    {
        Task<List<ActorFilm>> GetActorFilmeAsync();
        Task<ActorFilm> GetActorFilmByIdAsync(int actorFilmId);
        Task AddActorFilmAsync(ActorFilm actorFilm);
        // Alte metode pentru operații specifice
    }
}
