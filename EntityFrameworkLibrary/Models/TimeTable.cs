﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

namespace EntityFrameworkLibrary.Models;

public partial class TimeTable
{
    public int id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }
}