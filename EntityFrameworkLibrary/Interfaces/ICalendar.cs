#nullable disable
namespace EntityFrameworkLibrary.Interfaces;

public interface ICalendar
{
    DateOnly CalendarDate { get; set; }
    int CalendarYear { get; set; }
    int CalendarMonth { get; set; }
    int CalendarDay { get; set; }
    string DayOfWeekName { get; set; }
    DateOnly FirstDateOfWeek { get; set; }
    DateOnly LastDateOfWeek { get; set; }
    DateOnly FirstDateOfMonth { get; set; }
    DateOnly LastDateOfMonth { get; set; }
    DateOnly FirstDateOfQuarter { get; set; }
    DateOnly LastDateOfQuarter { get; set; }
    DateOnly FirstDateOfYear { get; set; }
    DateOnly LastDateOfYear { get; set; }
    bool BusinessDay { get; set; }
    bool NonBusinessDay { get; set; }
    bool Weekend { get; set; }
    bool Holiday { get; set; }
    bool Weekday { get; set; }
    string Description { get; set; }
}