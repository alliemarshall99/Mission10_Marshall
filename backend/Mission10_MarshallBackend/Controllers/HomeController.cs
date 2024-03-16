using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission10_MarshallBackend.Models;
using System.Diagnostics;

namespace Mission10_MarshallBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the Bowling League API!");
        }

        [HttpGet("privacy")]
        public IActionResult Privacy()
        {
            return Ok("This is the privacy policy of the Bowling League API.");
        }

        [HttpGet("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Ok(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
