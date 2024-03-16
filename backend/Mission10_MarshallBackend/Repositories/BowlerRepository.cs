using Mission10_MarshallBackend.Data;
using Mission10_MarshallBackend.Models;

namespace Mission10_MarshallBackend.Repositories
{
    public class BowlerRepository
    {
        private readonly BowlingLeagueDbContext _context;

        public BowlerRepository(BowlingLeagueDbContext context)
        {
            _context = context;
        }

        public List<Bowler> GetBowlersForMarlinsAndSharks()
        {
            var bowlers = _context.Bowlers.Where(b => b.TeamID == 1 || b.TeamID == 2).ToList();
            return bowlers;
        }
    }
}
