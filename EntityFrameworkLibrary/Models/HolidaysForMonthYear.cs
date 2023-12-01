#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace EntityFrameworkLibrary.Models;
public class HolidaysForMonthYear
{
    public DateOnly CalendarDate { get; set; }
    public int CalendarYear { get; set; }
    public int CalendarDay { get; set; }
    public string DayOfWeekName { get; set; }
    public string Weekend { get; set; }
    public string Weekday { get; set; }
    public string Description { get; set; }
}
