namespace CalendarStoredProcedure.Models;

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