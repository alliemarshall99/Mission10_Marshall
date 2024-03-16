using System.Collections.Generic;
using Mission10_MarshallBackend.Data;
using Mission10_MarshallBackend.Models;

namespace Mission10_MarshallBackend.Repositories
{
    public class TeamRepository
    {
        private readonly BowlingLeagueDbContext _dbContext;

        public TeamRepository(BowlingLeagueDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Team> GetAll()
        {
            return _dbContext.Teams.ToList();
        }


    }
}
