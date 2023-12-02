using CalendarStoredProcedure.Data;
using CalendarStoredProcedure.Models;

namespace CalendarStoredProcedure;

    internal partial class Program
    {
        static async Task Main(string[] args)
        {
            await using var context = new Context();
            List<usp_HolidaysForMonthYearResult> holidays = 
                await context.GetProcedures()
                    .usp_HolidaysForMonthYearAsync();

            Console.ReadLine();

        }
    }




