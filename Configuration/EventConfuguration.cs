using EFCoreAssignment02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment02.Configuration
{
    internal class EventConfuguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("TableEvent");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(e => e.Description)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(e => e.StartTime)
                .IsRequired(true);

            builder.Property(e => e.EndDate)
                .IsRequired(true);

            builder.Property(e => e.MaxNumAttendees)
                .IsRequired(true);


            builder.HasOne(e => e.organizers)
                .WithMany(o => o.EventAttend)
                .HasForeignKey(e => e.Id)
                .OnDelete(DeleteBehavior.Restrict);

            
        }
    }
}
