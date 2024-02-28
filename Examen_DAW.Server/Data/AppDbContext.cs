using Examen_DAW.Server.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Actor> Actorii { get; set; }
    public DbSet<Film> Filme { get; set; }
    public DbSet<ActorFilm> ActorFilme { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActorFilm>()
            .HasKey(af => new { af.ActorId, af.FilmId });

        modelBuilder.Entity<ActorFilm>()
            .HasOne(af => af.Actor)
            .WithMany(a => a.ActorFilme)
            .HasForeignKey(af => af.ActorId);

        modelBuilder.Entity<ActorFilm>()
            .HasOne(af => af.Film)
            .WithMany(f => f.ActorFilme)
            .HasForeignKey(af => af.FilmId);
    }
}
