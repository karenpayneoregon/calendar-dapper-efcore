﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using EntityFrameworkLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EntityFrameworkLibrary.Data.Configurations
{
    public partial class EventsConfiguration : IEntityTypeConfiguration<Events>
    {
        public void Configure(EntityTypeBuilder<Events> entity)
        {
            entity.HasKey(e => e.EventID).HasName("PK__Events__7944C8704393EF0A");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Events> entity);
    }
}
