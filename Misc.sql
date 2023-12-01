DECLARE @CalendarMonthStart AS INT = 1;
DECLARE @CalendarMonthEnd AS INT = 6;
DECLARE @Holiday AS BIT = 1;
DECLARE @CalendarYear AS INT = 2023;

SELECT CalendarDate,
       CalendarYear,
       CalendarMonth,
       CalendarDay,
       DayOfWeekName,
       FirstDateOfWeek,
       LastDateOfWeek,
       FirstDateOfMonth,
       LastDateOfMonth,
       FirstDateOfQuarter,
       LastDateOfQuarter,
       FirstDateOfYear,
       LastDateOfYear,
       BusinessDay,
       NonBusinessDay,
       Weekend,
       Holiday,
       [Weekday],
       CalendarDateDescription
FROM DateTimeDatabase.dbo.Calendar
WHERE CalendarMonth
      BETWEEN @CalendarMonthStart AND @CalendarMonthEnd
      AND Holiday = @Holiday
      AND CalendarYear = @CalendarYear;

-- 

SELECT CalendarDate,
       CalendarYear,
       CalendarMonth,
       CalendarDay,
       DayOfWeekName,
       FirstDateOfWeek,
       LastDateOfWeek,
       FirstDateOfMonth,
       LastDateOfMonth,
       FirstDateOfQuarter,
       LastDateOfQuarter,
       FirstDateOfYear,
       LastDateOfYear,
       BusinessDay,
       NonBusinessDay,
       Weekend,
       Holiday,
       [Weekday],
       CalendarDateDescription
FROM DateTimeDatabase.dbo.Calendar
WHERE CalendarMonth = MONTH(GETDATE())