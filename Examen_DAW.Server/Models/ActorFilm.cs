using Examen_DAW.Server.Models;

public class ActorFilm
{
    public int ActorFilmId { get; set; } 

    public int ActorId { get; set; }
    public Actor Actor { get; set; }

    public int FilmId { get; set; }
    public Film Film { get; set; }
}
