using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Controllers;
using MyWebAPI.Services;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _calculationService;

        public CalculationController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            var result = _calculationService.Add(a, b);
            return Ok(result);
        }
    }
}
