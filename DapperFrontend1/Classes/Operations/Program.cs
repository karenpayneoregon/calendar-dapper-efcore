using DapperFrontend1.Classes;
using DapperLibrary;
using Calendar = DapperLibrary.Models.Calendar;
using static UtilityLibrary.SpectreConsoleHelpers;

// ReSharper disable once CheckNamespace
namespace DapperFrontend1;
internal partial class Program
{
    public static async Task Example1()
    {
        PrintCyan();

        int year = 2023;
        int month = 5;
        bool businessDay = true;
        string dow = DayOfWeek.Monday.ToString();

        Operations operations = new();
        List<Calendar> list = await operations.GetCalendar(year, month, businessDay, dow);

        foreach (var cal in list)
        {
            Console.WriteLine($"{cal.CalendarDate,-10:MM/dd/yyyy} {cal.CalendarDay,3} {cal.Holiday.ToYesNo(),-4}");
        }
    }
    private static async Task Example2()
    {
        PrintCyan();

        int year = 2023;
        int startMonth = 1;
        int endMonth = 6;

        Operations operations = new();
        var list = await operations.HolidaysInYearBetweenMonths(startMonth, endMonth,true, year);
        foreach (var cal in list)
        {
            Console.WriteLine($"{cal.CalendarDate,-10:MM/dd/yyyy} {cal.CalendarDay,-3} {cal.Description}");
        }
    }

    private static async Task Example3()
    {
        PrintCyan();

        Operations operations = new();
        var list = await operations.HolidaysForMonthYear();

        foreach (var item in list)
        {
            Console.WriteLine($"{item.CalendarDate,-12}{item.Description}");
        }
    }
}
