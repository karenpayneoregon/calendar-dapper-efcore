#nullable disable
namespace DapperLibrary.Models;

public partial class People
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public bool? Gender { get; set; }

    public DateTime? BirthDay { get; set; }

    public string PhoneNumber { get; set; }
}