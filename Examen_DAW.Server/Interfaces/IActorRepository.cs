// Examen_DAW.Server/Interfaces/IActorRepository.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using Examen_DAW.Server.Models;

namespace Examen_DAW.Server.Interfaces
{
    public interface IActorRepository
    {
        Task<List<Actor>> GetActoriiAsync();
        Task<Actor> GetActorByIdAsync(int actorId);
        Task AddActorAsync(Actor actor);
        // Alte metode pentru operații specifice
    }
}
