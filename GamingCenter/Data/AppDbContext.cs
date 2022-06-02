using GamingCenter.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GamingCenter.Data
{
   public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client_Services>().HasOne(s => s.Service).WithMany(cs=>cs.Client_Services).HasForeignKey(si=>si.ServicesId);
            modelBuilder.Entity<Client_Services>().HasOne(s => s.Clients).WithMany(cs => cs.Client_Services).HasForeignKey(si => si.ClientId);

        }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<Clients> Clients{ get; set; }
        public DbSet<Client_Services> Client_Services { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Sectors> Sectors {get; set; }

    }
}
