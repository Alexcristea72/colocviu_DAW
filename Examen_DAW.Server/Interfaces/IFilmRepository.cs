// Examen_DAW.Server/Interfaces/IFilmRepository.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using Examen_DAW.Server.Models;

namespace Examen_DAW.Server.Interfaces
{
    public interface IFilmRepository
    {
        Task<List<Film>> GetFilmeAsync();
        Task<Film> GetFilmByIdAsync(int filmId);
        Task AddFilmAsync(Film film);
        // Alte metode pentru operații specifice
    }
}
