﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using EntityFrameworkLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkLibrary.Data.Configurations;

public partial class CalendarConfiguration : IEntityTypeConfiguration<Calendar>
{
    public void Configure(EntityTypeBuilder<Calendar> entity)
    {
        entity.HasKey(e => e.CalendarDate);

        entity.Property(e => e.Description)
            .HasMaxLength(50)
            .IsUnicode(false);
        entity.Property(e => e.DayOfWeekName)
            .IsRequired()
            .HasMaxLength(10)
            .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Calendar> entity);
}