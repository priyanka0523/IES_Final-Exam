using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class VideoGamesController : ControllerBase
    {


        private readonly List<VideoGames> Games = new List<VideoGames>()
        {
            new VideoGames { id = 03, name = "Mario", price=1000, type="Adventure"},
            new VideoGames { id = 02, name = "Minecraft", price=1500, type="SandBox " },
            new VideoGames { id = 04, name = "overwatch", price=2000, type="Shootimg" },
            new VideoGames { id = 01, name = "Apex Legends", price=2500, type="Racing" },


        };

        private readonly ILogger<VideoGamesController> _logger;
        public VideoGamesController(ILogger<VideoGamesController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<VideoGames> Get()
        {
            return Games;
        }
        [HttpGet("{id:int}")]
        public VideoGames GetOne(int id)
        {
            return Games.SingleOrDefault(x => x.id == id);
        }



    }
}

