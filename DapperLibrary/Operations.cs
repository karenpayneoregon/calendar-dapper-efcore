using Dapper;
using DapperLibrary.Handlers;
using Microsoft.Data.SqlClient;
using System.Data;
using DapperLibrary.Models;

namespace DapperLibrary;
public class Operations
{
    private IDbConnection cn;

    public Operations()
    {
        cn = new SqlConnection(ConnectionString());
        SqlMapper.AddTypeHandler(new DapperSqlDateOnlyTypeHandler());
    }

    public async Task<List<Calendar>> GetCalendar(int year, int month, bool businessDay, string dow) =>
        (List<Calendar>)await cn.QueryAsync<Calendar>(SqlStatements.GetCalendar,
            new
            {
                CalendarYear = year,
                CalendarMonth = month,
                BusinessDay = businessDay,
                DayOfWeekName = dow
            });

    public async Task<List<Calendar>> HolidaysInYearBetweenMonths(int calendarMonthStart, int calendarMonthEnd, bool holiday, int calendarYear) =>
        (List<Calendar>)await cn.QueryAsync<Calendar>(SqlStatements.HolidaysByYearMonthsBetween,
            new
            {
                CalendarMonthStart = calendarMonthStart,
                CalendarMonthEnd = calendarMonthEnd,
                Holiday = holiday,
                CalendarYear = calendarYear
            });

    public async Task<List<HolidaysForMonthYear>> HolidaysForMonthYear() =>
        (List<HolidaysForMonthYear>)await cn.QueryAsync<HolidaysForMonthYear>(
            SqlStatements.HolidaysForMonthYear);
}