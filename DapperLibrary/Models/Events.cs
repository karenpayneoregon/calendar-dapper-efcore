﻿#nullable disable
namespace DapperLibrary.Models;

public partial class Events
{
    public int EventID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}