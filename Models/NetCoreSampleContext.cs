using Microsoft.EntityFrameworkCore;
using NetCoreSample.Models;

namespace NetCoreSample.Models
{
    public class NetCoreSampleContext : DbContext
    {
        public NetCoreSampleContext(DbContextOptions<NetCoreSampleContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasIndex(u => u.Username)
                 .IsUnique();
        }
        public DbSet<User> Users { get; set; }
    }
}