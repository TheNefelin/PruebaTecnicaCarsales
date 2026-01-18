using ClassLibrary_Application.DTOs;
using ClassLibrary_Application.Interfaces;
using ClassLibrary_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EpisodeController : ControllerBase
{
    private readonly ILogger<EpisodeController> _logger;
    private readonly IExternalEpisodeService _episodeService;

    public EpisodeController(
        ILogger<EpisodeController> logger,
        IExternalEpisodeService episodeService)
    {
        _logger = logger;
        _episodeService = episodeService;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<List<EpisodeDto>>>> GetEpisodes(
        [FromQuery] int page = 1,
        [FromQuery] string? name = null)
    {
        if (page <= 0)
        {
            _logger.LogWarning("Invalid page number requested: {Page}", page);
            return BadRequest("Page must be greater than 0");
        }

        try
        {
            _logger.LogInformation("Fetching episodes. Page: {Page}, Name filter: {Name}", page, name ?? "null");
            var result = await _episodeService.GetEpisodesAsync(page, name);

            _logger.LogInformation("Successfully fetched {Count} episodes for page {Page}", result.Results.Count, page);
            return Ok(result);
        }
        catch (ApplicationException ex)
        {
            _logger.LogError(ex, "Application exception while fetching episodes. Page: {Page}, Name: {Name}", page, name);

            if (ex.Message.Contains("Page not found"))
                return NotFound(new { message = ex.Message });

            if (ex.Message.Contains("Error calling external API"))
                return new PagedResult<List<EpisodeDto>>
                {
                    Results = new List<EpisodeDto>(),
                    Page = page,
                    TotalPages = 0
                };

            // Para cualquier otro error de la API externa
            return StatusCode(502, new { message = ex.Message });
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex, "Unexpected error while fetching episodes. Page: {Page}, Name: {Name}", page, name);
            return StatusCode(500, new { message = "Internal server error" });
        }
    }
}
