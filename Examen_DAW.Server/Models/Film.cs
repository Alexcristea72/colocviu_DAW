using System.Collections.Generic;

public class Film
{
    public int FilmId { get; set; }
    public string Titlu { get; set; }

    public ICollection<ActorFilm> ActorFilme { get; set; }
}
