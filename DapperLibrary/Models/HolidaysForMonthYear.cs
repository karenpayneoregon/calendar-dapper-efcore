using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperLibrary.Models;
public class HolidaysForMonthYear
{
    public DateOnly CalendarDate { get; set; }
    public int CalendarYear { get; set; }
    public int CalendarDay { get; set; }
    public string DayOfWeekName { get; set; }
    public string Weekend { get; set; }
    public string Weekday { get; set; }
    public string Description { get; set; }
}
