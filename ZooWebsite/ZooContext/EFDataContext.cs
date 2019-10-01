using Microsoft.EntityFrameworkCore;
using ZooWebsite.Models;

namespace ZooWebsite.ZooContext
{
    public class EFDataContext : DbContext
    {
        public DbSet<AboutZoo> AboutZoos { get; set; }

        public DbSet<Animals> Animals { get; set; }

        public DbSet<AnimalType> AnimalTypes { get; set; }

        public DbSet<Announcements> Announcements { get; set; }

        public DbSet<DailySales> DailySales { get; set; }

        public DbSet<TicketAvailability> TicketAvailabilities { get; set; }

        public EFDataContext(DbContextOptions<EFDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
