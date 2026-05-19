using GymSystemG04.Configurations;
using GymSystemG04.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSystemG04.AppDbContexts
{
    public class GymDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymManagmentG04;Trusted_Connection=true;TrustServerCertificate=true;");
        }


        public DbSet<Plan> Plans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanConfiguration());
        }


    }
}
