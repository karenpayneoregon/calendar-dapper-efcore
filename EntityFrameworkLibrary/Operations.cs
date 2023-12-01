using EntityFrameworkLibrary.Classes;
using EntityFrameworkLibrary.Data;
using EntityFrameworkLibrary.Interfaces;
using EntityFrameworkLibrary.Models;
using Microsoft.EntityFrameworkCore;

#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.

namespace EntityFrameworkLibrary;

public class Operations
{
    public static async Task<List<Calendar>> GetCalendar(int year, int month, bool businessDay, string dow)
    {

        await using var context = new Context();

        var list = await context.Calendar.Where(calendar =>
            calendar.CalendarYear == year &&
            calendar.CalendarMonth == month &&
            calendar.BusinessDay == businessDay && calendar.DayOfWeekName == dow).ToListAsync();

        return list;

    }
    public static async Task<List<Calendar>> HolidaysInYearBetweenMonths(int year, int startMonth, int endMonth)
    {
        await using var context = new Context();

        List<Calendar> list = await context.Calendar
            .WhereDatesBetween(startMonth, endMonth)
            .Where(x => x.CalendarYear == year && x.Holiday)
            .ToListAsync();

        //List<Calendar> newList = test.Cast<Calendar>().ToList();

        return list;
    }

    public static async Task<List<HolidaysForMonthYear>> HolidaysForMonthYear()
    {
        await using var context = new Context();
        var list = await context.Database.SqlQuery<HolidaysForMonthYear>(
            $"""
             SELECT CalendarDate,
                    CalendarYear,
                    CalendarDay,
                    DayOfWeekName,
                    CASE
                        WHEN Weekend = 1 THEN
                            'Yes'
                        ELSE
                            'No'
                    END AS Weekend,
                    CASE
                        WHEN Weekday = 1 THEN
                            'Yes'
                        ELSE
                            'No'
                    END AS Weekday,
                    CalendarDateDescription AS Description
             FROM dbo.Calendar
             WHERE CalendarMonth = MONTH(GETDATE())
                   AND CalendarYear = CAST(YEAR(GETDATE()) AS INT)
                   AND Holiday = 1;
             """).ToListAsync();

        return list;
    }
}