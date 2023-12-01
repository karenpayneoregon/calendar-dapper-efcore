#nullable disable
namespace DapperLibrary.Models;

public partial class Sales
{
    public int Id { get; set; }

    public DateTime? SaleDate { get; set; }

    public int? ShipCountry { get; set; }
}