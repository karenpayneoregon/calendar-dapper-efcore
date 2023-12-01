#nullable disable
namespace DapperLibrary.Models;

public partial class Birthdays
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateOnly? BirthDate { get; set; }
}