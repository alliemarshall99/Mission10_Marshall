using Microsoft.EntityFrameworkCore;
using Mission10_MarshallBackend.Models;

namespace Mission10_MarshallBackend.Data
{
    public class BowlingLeagueDbContext : DbContext
    {
        public BowlingLeagueDbContext(DbContextOptions<BowlingLeagueDbContext> options) : base(options) { }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BowlingLeague.sqlite");
        }
        */
    } 
} 
