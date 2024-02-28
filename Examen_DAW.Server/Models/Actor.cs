using System.Collections.Generic;
namespace Examen_DAW.Server.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Nume { get; set; }
        public ICollection<ActorFilm> ActorFilme { get; set; }


    }
}
