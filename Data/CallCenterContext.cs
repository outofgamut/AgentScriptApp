using AgentScriptApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgentScriptApp.Data
{
    public class CallCenterContext : DbContext
    {
        public CallCenterContext(DbContextOptions<CallCenterContext> options) : base(options)
        {
        }

        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Plan> Plans { get; set; }

        //Override to create singular table names instead of plural
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>().ToTable("Campaign");
            modelBuilder.Entity<Plan>().ToTable("Plan");
        }
    }
}