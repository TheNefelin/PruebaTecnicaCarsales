

using ClassLibrary_Application.DTOs;
using ClassLibrary_Infrastructure.ExternalModels;

namespace ClassLibrary_Infrastructure.Mappers;

public class EpisodeMapper
{
    public static EpisodeDto ToDto(ExternalEpisode episode)
    {
        return new EpisodeDto
        {
            Id = episode.id,
            Name = episode.name,
            Code = episode.episode,
            AirDate = episode.air_date,
            CharacterIds = episode.characters
                .Select(url => int.Parse(url.Split('/').Last()))
                .ToList()
        };
    }
}
