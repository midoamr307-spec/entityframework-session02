using EFCoreAssignment02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment02.Context
{
    internal class EventHubPlatFormDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; DataBase=EventPlatformDB; trusted_connection=true;trustServerCertificate=true;");
        }




        //-------------------------------------------
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendees> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }

    }
}
