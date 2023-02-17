namespace Fakeflix.Common.DTOs;

public class SimilarFilmsDTO
{
    public int FilmId { get; set; }
    public int SimilarFilmId { get; set; }

    public FilmDTO Film { get; set; }
    public FilmDTO Similar { get; set; }
}

public class SimilarFilmsCreateDTO
{
    public int FilmId { get; set; }
    public int SimilarFilmId { get; set; }
}
