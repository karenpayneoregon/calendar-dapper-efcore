namespace DapperLibrary;
public class SqlStatements
{
    public static string GetCalendar => 
        """
        SELECT c.CalendarDate,
               c.BusinessDay,
               c.CalendarDateDescription,
               c.CalendarDay,
               c.CalendarMonth,
               c.CalendarYear,
               c.DayOfWeekName,
               c.Holiday,
               c.NonBusinessDay,
               c.[Weekday],
               c.Weekend
        FROM dbo.Calendar AS c
        WHERE c.CalendarYear = @CalendarYear
              AND c.CalendarMonth = @CalendarMonth
              AND c.BusinessDay = @BusinessDay
              AND c.DayOfWeekName = @DayOfWeekName;
        """;

    public static string HolidaysByYearMonthsBetween =>
        """
        SELECT CalendarDate
            ,CalendarYear
            ,CalendarMonth
            ,CalendarDay
            ,DayOfWeekName
            ,BusinessDay
            ,NonBusinessDay
            ,Weekend
            ,Holiday
            ,Weekday
            ,CalendarDateDescription as Description
        FROM dbo.Calendar
        WHERE CalendarMonth BETWEEN @CalendarMonthStart AND @CalendarMonthEnd AND 
            Holiday = @Holiday AND 
            CalendarYear = @CalendarYear
        """;

    public static string HolidaysForMonthYear => 
        """
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
        """;
}
