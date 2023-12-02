﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

using Microsoft.EntityFrameworkCore;
using Calendar = CalendarStoredProcedure.Models.Calendar;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace CalendarStoredProcedure.Data;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Models.Calendar> Calendars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.HasKey(e => e.CalendarDate);

            entity.ToTable("Calendar");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DayOfWeekName)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}