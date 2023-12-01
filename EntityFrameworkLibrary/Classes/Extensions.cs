using EntityFrameworkLibrary.Interfaces;
using EntityFrameworkLibrary.Models;

namespace EntityFrameworkLibrary.Classes;

#pragma warning disable CS8619
public static class Extensions
{
    public static IQueryable<Calendar> WhereDatesBetween(this IQueryable<Calendar> sender, int startDate, int endDate)
        => sender.Where(calendar => startDate <= calendar.CalendarMonth && calendar.CalendarMonth <= endDate);

    public static IQueryable<ICalendar> WhereDatesBetween1(this IQueryable<ICalendar> sender, int startDate, int endDate)
        => sender.Where(calendar => startDate <= calendar.CalendarMonth && calendar.CalendarMonth <= endDate);
}