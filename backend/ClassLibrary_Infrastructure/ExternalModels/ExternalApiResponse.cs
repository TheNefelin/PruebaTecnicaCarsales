namespace ClassLibrary_Infrastructure.ExternalModels;

public class ExternalApiResponse<T>
{
    public ExternalInfo info { get; set; }
    public T results { get; set; }
}
