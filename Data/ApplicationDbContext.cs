using Microsoft.EntityFrameworkCore;

namespace CaseManagement.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : base(options)
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appearance> Appearances { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<Citation> Citations { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Officer> Officers { get; set; }
        public DbSet<Ordinance> Ordinances { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<TrafficCitation> TrafficCitations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
