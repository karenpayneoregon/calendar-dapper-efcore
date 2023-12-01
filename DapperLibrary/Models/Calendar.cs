﻿#nullable disable
using System.ComponentModel.DataAnnotations.Schema;
using DapperLibrary.Interfaces;

namespace DapperLibrary.Models;

public partial class Calendar : ICalendar
{
    public DateOnly CalendarDate { get; set; }

    public int CalendarYear { get; set; }

    public int CalendarMonth { get; set; }

    public int CalendarDay { get; set; }

    public string DayOfWeekName { get; set; }

    public DateOnly FirstDateOfWeek { get; set; }

    public DateOnly LastDateOfWeek { get; set; }

    public DateOnly FirstDateOfMonth { get; set; }

    public DateOnly LastDateOfMonth { get; set; }

    public DateOnly FirstDateOfQuarter { get; set; }

    public DateOnly LastDateOfQuarter { get; set; }

    public DateOnly FirstDateOfYear { get; set; }

    public DateOnly LastDateOfYear { get; set; }

    public bool BusinessDay { get; set; }

    public bool NonBusinessDay { get; set; }

    public bool Weekend { get; set; }

    public bool Holiday { get; set; }

    public bool Weekday { get; set; }
    [Column("CalendarDateDescription")]
    public string Description { get; set; }
}