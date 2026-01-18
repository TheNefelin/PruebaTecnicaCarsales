namespace ClassLibrary_Application.Models;

public class PagedResult<T>
{
    public int Page { get; set; }
    public int TotalPages { get; set; }
    public int TotalItems { get; set; }
    public string? Next { get; set; }
    public string? Prev { get; set; }
    public T Results { get; set; }
}
