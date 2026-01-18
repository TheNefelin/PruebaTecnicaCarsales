namespace ClassLibrary_Application.DTOs;

public class EpisodeDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string AirDate { get; set; }
    public List<int> CharacterIds { get; set; } = [];
}
