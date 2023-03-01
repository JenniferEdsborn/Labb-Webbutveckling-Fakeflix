namespace Fakeflix.Common.Services;

public class MembershipService : IMembershipService
{
    protected readonly MembershipHttpClient _http;

    public MembershipService(MembershipHttpClient httpClient)
    {
        _http = httpClient;
    }

    public async Task<List<FilmDTO>> GetFilmsAsync()
    {
        try
        {
            using HttpResponseMessage response = await _http.Client.GetAsync($"film?freeOnly={false}");
            response.EnsureSuccessStatusCode();

            var result = JsonSerializer.Deserialize<List<FilmDTO>>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? new List<FilmDTO>();

        }
        catch { throw; }
    }

    public async Task<FilmDTO> GetFilmAsync(int id)
    {
        try
        {
            using HttpResponseMessage response = await _http.Client.GetAsync($"film/{id}");
            response.EnsureSuccessStatusCode();

            var result = JsonSerializer.Deserialize<FilmDTO>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? new FilmDTO();

        }
        catch { throw; }
    }

    public async Task<List<GenreDTO>> GetGenresAsync()
    {
        try
        {
            using HttpResponseMessage response = await _http.Client.GetAsync("genre");
            response.EnsureSuccessStatusCode();

            var result = JsonSerializer.Deserialize<List<GenreDTO>>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? new List<GenreDTO>();

        }
        catch { throw; }
    }

    public async Task<List<FilmGenreDTO>> GetFilmGenresAsync()
    {
        try
        {
            using HttpResponseMessage response = await _http.Client.GetAsync("filmgenre");
            response.EnsureSuccessStatusCode();

            var result = JsonSerializer.Deserialize<List<FilmGenreDTO>>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? new List<FilmGenreDTO>();

        }
        catch { throw; }
    }

    public async Task<List<SimilarFilmsDTO>> GetSimilarFilmsAsync()
    {
        try
        {
            using HttpResponseMessage response = await _http.Client.GetAsync("similarfilms");
            response.EnsureSuccessStatusCode();

            var result = JsonSerializer.Deserialize<List<SimilarFilmsDTO>>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? new List<SimilarFilmsDTO>();

        }
        catch { throw; }
    }

    public async Task<List<DirectorDTO>> GetDirectorsAsync()
    {
        try
        {
            using HttpResponseMessage response = await _http.Client.GetAsync("director");
            response.EnsureSuccessStatusCode();

            var result = JsonSerializer.Deserialize<List<DirectorDTO>>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? new List<DirectorDTO>();

        }
        catch { throw; }
    }
}

