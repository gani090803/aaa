using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SaveContext : DbContext
    {
        public SaveContext()
        {
        }

        public SaveContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Save>? Saves { get; set; }
        public DbSet<Club>? Clubs { get; set; }
        public DbSet<Squad>? Squads { get; set; }
        public DbSet<StartingEleven>? StartingElevens { get; set; }
        public DbSet<Bench>? Benches { get; set; }
        public DbSet<Reserves>? Reserves { get; set; }
        public DbSet<Player>? Players { get; set; }
        public DbSet<Stats> Stats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    (@"Server =.; Database = FootballManagerDB; Trusted_Connection = True; ");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stats>()
                .HasKey(s => new { s.Id });
        }
    }
}
