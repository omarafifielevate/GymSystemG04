using GymSystem.DAL.Configurations;
using GymSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.DAL.AppDbContexts
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {
            
        }

        public DbSet<Plan> Plans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanConfiguration());
        }


    }
}
