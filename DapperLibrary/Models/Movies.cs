#nullable disable
namespace DapperLibrary.Models;

public partial class Movies
{
    public int Id { get; set; }

    public TimeOnly? Duration { get; set; }

    public string Title { get; set; }
}