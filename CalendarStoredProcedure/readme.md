# About

Simple example for a stored procedure that was reverse engineered with EF Core Power Tools.

Two simple examples, one Dapper, one EF Core.

## Model SQL for Stored procedure

```sql
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
```