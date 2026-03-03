using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Controllers;
using MyWebAPI.Services;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly ITimeService _timeService;

        public TimeController(ITimeService timeService)
        {
            _timeService = timeService;
        }

        [HttpGet("gettime")]
        public IActionResult Get()
        {            
            var time = _timeService.GetCurrentTime();
            return Ok(time);
        }
    }
}