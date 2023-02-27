using Fakeflix.Common.DTOs;

namespace Fakeflix.Common.Services
{
    public interface IMembershipService
    {
        Task<FilmDTO> GetFilmAsync(int id);
        Task<List<FilmGenreDTO>> GetFilmGenresAsync();
        Task<List<FilmDTO>> GetFilmsAsync();
        Task<List<GenreDTO>> GetGenresAsync();
    }
}