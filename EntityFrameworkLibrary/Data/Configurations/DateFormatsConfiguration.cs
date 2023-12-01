﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using EntityFrameworkLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkLibrary.Data.Configurations
{
    public partial class DateFormatsConfiguration : IEntityTypeConfiguration<DateFormats>
    {
        public void Configure(EntityTypeBuilder<DateFormats> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.dateOutput).HasMaxLength(40);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DateFormats> entity);
    }
}