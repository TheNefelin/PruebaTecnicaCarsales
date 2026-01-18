using ClassLibrary_Application.DTOs;
using ClassLibrary_Application.Interfaces;
using ClassLibrary_Application.Models;
using ClassLibrary_Infrastructure.ExternalModels;
using ClassLibrary_Infrastructure.Mappers;
using System.Net.Http.Json;
using System.Text.Json;

namespace ClassLibrary_Infrastructure.ExternalServices;

public class ExternalEpisodeService : IExternalEpisodeService
{
    private readonly HttpClient _httpClient;

    public ExternalEpisodeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PagedResult<List<EpisodeDto>>> GetEpisodesAsync(int page, string? name)
    {
        var query = $"episode?page={page}";

        if (!string.IsNullOrWhiteSpace(name))
            query += $"&name={Uri.EscapeDataString(name)}";

        ExternalApiResponse<List<ExternalEpisode>>? response;

        try
        {
            response = await _httpClient.GetFromJsonAsync<ExternalApiResponse<List<ExternalEpisode>>>(query);
        }
        catch (HttpRequestException)
        {
            throw new ApplicationException("Error calling external API");
        }
        catch (NotSupportedException)
        {
            throw new ApplicationException("Invalid content type from external API");
        }
        catch (JsonException)
        {
            throw new ApplicationException("Invalid JSON from external API");
        }

        if (response == null)
            throw new ApplicationException("Empty response from external API");

        return new PagedResult<List<EpisodeDto>>
        {
            Page = page,
            TotalPages = response.info.pages,
            TotalItems = response.info.count,
            Next = response.info.next,
            Prev = response.info.prev,
            Results = response.results
                .Select(EpisodeMapper.ToDto)
                .ToList()
        };
    }
}
