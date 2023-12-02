using System.Data;
using System.Data.SqlClient;
using CalendarStoredProcedure.Data;
using CalendarStoredProcedure.Models;
using Dapper;
using DapperLibrary.Handlers;
using Calendar = CalendarStoredProcedure.Models.Calendar;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace CalendarStoredProcedure;

internal partial class Program
{
    static async Task Main(string[] args)
    {
        await using var context = new Context();
        List<usp_HolidaysForMonthYearResult> holidaysEf =
            await context.GetProcedures()
                .usp_HolidaysForMonthYearAsync();

        List<usp_HolidaysForMonthYearResult> holidaysDapper = await DapperStoredProcedure();

        Console.WriteLine($"    EF Core count {holidaysEf.Count}");
        Console.WriteLine($"Dapper Core count {holidaysDapper.Count}");
        Console.ReadLine();

    }

    /// <summary>
    /// Dapper mirror image of EF Core
    /// - setup for DateOnly
    /// - create connection
    /// - call stored procedure
    /// </summary>
    public static async Task<List<usp_HolidaysForMonthYearResult>> DapperStoredProcedure()
    {
        SqlMapper.AddTypeHandler(new DapperSqlDateOnlyTypeHandler());
        await using SqlConnection cn = new(ConnectionString());

        var results = await cn.QueryAsync<usp_HolidaysForMonthYearResult>(
            "usp_HolidaysForMonthYear",
            null, 
            null, 
            null,
            CommandType.StoredProcedure);

        return results.AsList();
    }
}