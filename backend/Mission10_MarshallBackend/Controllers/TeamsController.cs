using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Mission10_MarshallBackend.Models;
using Mission10_MarshallBackend.Repositories;


[ApiController]
[Route("[controller]")]
public class TeamsController : ControllerBase
{
    private readonly TeamRepository _teamRepository;

    public TeamsController(TeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    [HttpGet]
    public ActionResult<List<Team>> GetAllTeams()
    {
        var teams = _teamRepository.GetAll();
        return Ok(teams);
    }


}
