using EntityFrameworkLibrary;
using EntityFrontend1.Classes;
using static UtilityLibrary.SpectreConsoleHelpers;

// ReSharper disable once CheckNamespace
namespace EntityFrontend1;
internal partial class Program
{
    /// <summary>
    /// Get records that are in the year 2023, month May, is business day and Monday
    /// </summary>
    public static async Task Example1()
    {
        PrintCyan();

        int year = 2023;
        int month = 5;
        bool businessDay = true;
        string dow = DayOfWeek.Monday.ToString();

        var list = await Operations.GetCalendar(year, month, businessDay, dow);

        foreach (var cal in list)
        {
            Console.WriteLine($"{cal.CalendarDate,-10:MM/dd/yyyy} {cal.CalendarDay,3} {cal.Holiday.ToYesNo(),-4}");
        }
    }

    /// <summary>
    /// Get records for the year 2023, months between January and June
    /// </summary>
    private static async Task Example2()
    {
        PrintCyan();

        int year = 2023;
        int startMonth = 1;
        int endMonth = 6;

        var list = await Operations.HolidaysInYearBetweenMonths(year, startMonth, endMonth);
        foreach (var cal in list)
        {
            Console.WriteLine($"{cal.CalendarDate,-10:MM/dd/yyyy} {cal.CalendarDay,-3} {cal.Description}");
        }
    }

    private static async Task Example3()
    {
        PrintCyan();
        var list = await Operations.HolidaysForMonthYear();

        foreach (var item in list)
        {
            Console.WriteLine($"{item.CalendarDate,-12}{item.Description}");
        }
    }

}
