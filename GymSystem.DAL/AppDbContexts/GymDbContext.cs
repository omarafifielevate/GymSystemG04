using GymSystem.DAL.Configurations;
using GymSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymSystem.DAL.AppDbContexts
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {
            
        }

        public DbSet<Plan> Plans { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<HealthRecords> HealthRecords { get; set; }
        public DbSet<Category> Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
