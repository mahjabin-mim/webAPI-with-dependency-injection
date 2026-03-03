using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Controllers;
using MyWebAPI.Services;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        [HttpGet("getgreeting")]
        public IActionResult Get()
        {
            var greeting = _greetingService.GetGreeting();
            return Ok(greeting);
        }
    }
}
