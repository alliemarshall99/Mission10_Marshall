using Microsoft.AspNetCore.Mvc;
using Mission10_MarshallBackend.Models;
using Mission10_MarshallBackend.Repositories;

namespace Mission10_MarshallBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BowlersController : ControllerBase
    {
        private readonly BowlerRepository _bowlerRepository;

        public BowlersController(BowlerRepository bowlerRepository)
        {
            _bowlerRepository = bowlerRepository;
        }

        [HttpGet]
        public ActionResult<List<Bowler>> GetBowlersForMarlinsAndSharks()
        {
            var bowlers = _bowlerRepository.GetBowlersForMarlinsAndSharks();
            return Ok(bowlers);
        }
    }
}
