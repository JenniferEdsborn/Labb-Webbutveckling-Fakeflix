namespace Fakeflix.Membership.Database.Contexts;

public class LabbFakeflixContext : DbContext
{
    public virtual DbSet<Film> Films { get; set; } = null!;
    public virtual DbSet<SimilarFilms> SimilarFilms { get; set; } = null!;
    public virtual DbSet<Director> Directors { get; set; } = null!;
    public virtual DbSet<Genre> Genres { get; set; } = null!;
    public virtual DbSet<FilmGenre> FilmGenres { get; set; } = null!;

    public LabbFakeflixContext(DbContextOptions<LabbFakeflixContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SimilarFilms>().HasKey(ci => new { ci.FilmId, ci.SimilarFilmId });
        modelBuilder.Entity<FilmGenre>().HasKey(ci => new { ci.FilmId, ci.GenreId });

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Film>(entity =>
        {
            entity
                .HasMany(d => d.SimilarFilms)
                .WithOne(p => p.Film)
                .HasForeignKey(d => d.FilmId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasMany(d => d.Genres)
                  .WithMany(p => p.Films)
                  .UsingEntity<FilmGenre>()
                  .ToTable("FilmGenres");
        });

        //SeedData(modelBuilder);
    }

    public void SeedData(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Director>().HasData(
            new { Id = 1, Name = "Chloé Zhao" },
            new { Id = 2, Name = "Ava DuVernay" },
            new { Id = 3, Name = "Kathryn Bigelow" });

        modelBuilder.Entity<Film>().HasData(
            new { Id = 1, Title = "Wonder Woman", DirectorId = 1, Description = "Lorem ipsum", FilmUrl = "https://www.youtube.com/watch?v=yFQyrYSvqPI", Released = new DateTime(2022, 12, 10), Free = true },
            new { Id = 2, Title = "The Hulk", DirectorId = 1, Description = "Lorem ipsum", FilmUrl = "https://www.youtube.com/watch?v=IkOK8tdEsFY", Released = new DateTime(2021, 12, 10), Free = true },
            new { Id = 3, Title = "Cat Woman", DirectorId = 2, Description = "Lorem ipsum", FilmUrl = "https://www.youtube.com/watch?v=DKP16d_WdZM", Released = new DateTime(2020, 12, 10), Free = true },
            new { Id = 4, Title = "Harry Potter and the Sorcerers Stone", DirectorId = 2, Description = "Lorem ipsum", FilmUrl = "https://www.youtube.com/watch?v=CsGYh8AacgY", Released = new DateTime(2019, 12, 10), Free = true },
            new { Id = 5, Title = "Harry Potter and the Goblet of Fire", DirectorId = 3, Description = "Lorem ipsum", FilmUrl = "https://www.youtube.com/watch?v=jNQXAC9IVRw", Released = new DateTime(2012, 12, 10), Free = true },
            new { Id = 6, Title = "Star Wars : A New Hope", DirectorId = 3, Description = "Lorem ipsum", FilmUrl = "https://www.youtube.com/watch?v=QH2-TGUlwu4", Released = new DateTime(2018, 12, 10), Free = true },
            new { Id = 7, Title = "Star Wars: The Force Awakens", DirectorId = 3, Description = "Lorem ipsum", FilmUrl = "https://www.youtube.com/watch?v=e_04ZrNroTo", Released = new DateTime(2020, 01, 10), Free = true },
            new { Id = 8, Title = "Star Wars: The Last Jedi", DirectorId = 1, Description = "Lorem ipsum", FilmUrl = "https://www.youtube.com/watch?v=L0MK7qz13bU", Released = new DateTime(2002, 12, 10), Free = true });

        modelBuilder.Entity<SimilarFilms>().HasData(
            new SimilarFilms { FilmId = 1, SimilarFilmId = 2 },
            new SimilarFilms { FilmId = 1, SimilarFilmId = 3 },
            new SimilarFilms { FilmId = 2, SimilarFilmId = 1 },
            new SimilarFilms { FilmId = 2, SimilarFilmId = 3 },
            new SimilarFilms { FilmId = 4, SimilarFilmId = 5 },
            new SimilarFilms { FilmId = 5, SimilarFilmId = 4 },
            new SimilarFilms { FilmId = 6, SimilarFilmId = 7 },
            new SimilarFilms { FilmId = 6, SimilarFilmId = 8 },
            new SimilarFilms { FilmId = 7, SimilarFilmId = 6 },
            new SimilarFilms { FilmId = 7, SimilarFilmId = 8 },
            new SimilarFilms { FilmId = 8, SimilarFilmId = 6 },
            new SimilarFilms { FilmId = 8, SimilarFilmId = 7 });

        modelBuilder.Entity<Genre>().HasData(
            new { Id = 1, Name = "Action" },
            new { Id = 2, Name = "Sci-Fi" },
            new { Id = 3, Name = "Fantasy" });

        modelBuilder.Entity<FilmGenre>().HasData(
            new FilmGenre { FilmId = 1, GenreId = 1 },
            new FilmGenre { FilmId = 1, GenreId = 2 },
            new FilmGenre { FilmId = 2, GenreId = 1 },
            new FilmGenre { FilmId = 2, GenreId = 2 },
            new FilmGenre { FilmId = 3, GenreId = 1 },
            new FilmGenre { FilmId = 4, GenreId = 3 },
            new FilmGenre { FilmId = 5, GenreId = 3 },
            new FilmGenre { FilmId = 6, GenreId = 2 },
            new FilmGenre { FilmId = 7, GenreId = 2 },
            new FilmGenre { FilmId = 8, GenreId = 2 });
    }
}
