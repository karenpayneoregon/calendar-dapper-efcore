--- scripts written in SSMS

DECLARE @CalendarYear AS INT = 2023;
DECLARE @CalendarMonth AS INT = 5;
DECLARE @BusinessDay AS BIT = 1;
DECLARE @DayOfWeekName AS NVARCHAR(10) = N'Monday';
SELECT c.CalendarDate,
       c.BusinessDay,
       c.CalendarDateDescription,
       c.CalendarDay,
       c.CalendarMonth,
       c.CalendarYear,
       c.DayOfWeekName,
       c.FirstDateOfMonth,
       c.FirstDateOfQuarter,
       c.FirstDateOfWeek,
       c.FirstDateOfYear,
       c.Holiday,
       c.LastDateOfMonth,
       c.LastDateOfQuarter,
       c.LastDateOfWeek,
       c.LastDateOfYear,
       c.NonBusinessDay,
       c.Weekday,
       c.Weekend
FROM dbo.Calendar AS c
WHERE c.CalendarYear = @CalendarYear
      AND c.CalendarMonth = @CalendarMonth
      AND c.BusinessDay = @BusinessDay
      AND c.DayOfWeekName = @DayOfWeekName;
