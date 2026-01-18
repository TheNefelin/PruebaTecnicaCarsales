

using ClassLibrary_Application.DTOs;
using ClassLibrary_Application.Models;

namespace ClassLibrary_Application.Interfaces;

public interface IExternalEpisodeService
{
    Task<PagedResult<List<EpisodeDto>>> GetEpisodesAsync(int page, string? name);
}
