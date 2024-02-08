using ApiRest.Application;
using ApiRest.Entities;
using ApiRest.WebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoccerTeamController : ControllerBase
    {
        IApplication<SoccerTeam> _soccer;
        public SoccerTeamController(IApplication<SoccerTeam> soccer) { 
                _soccer= soccer;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_soccer.GetAll());
        }
        [HttpPost]
        public IActionResult Save(SoccerTeamCommandDto soccer)
        {
            var d = new SoccerTeam()
            {
                Name = soccer.Name,
                Score = soccer.Score,
                Manager = soccer.Manager,
            };
            return Ok(_soccer.Save(d));
        }
    }
}
