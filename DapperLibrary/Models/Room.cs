#nullable disable
namespace DapperLibrary.Models;

public partial class Room
{
    public int RoomIdentifier { get; set; }

    public int? Identifier { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? StartTime { get; set; }
}