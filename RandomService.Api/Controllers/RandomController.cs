using Microsoft.AspNetCore.Mvc;

namespace RandomService.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class RandomController : ControllerBase
    {
        private readonly ILogger<RandomController> _logger;
        private readonly RandomProvider _randomProvider;

        public RandomController(ILogger<RandomController> logger, RandomProvider randomProvider)
        {
            _logger = logger;
            _randomProvider = randomProvider;
        }

        [HttpGet("number")]
        public int Get(int min = 0, int max = 100) => _randomProvider.Get(min, max);

        [HttpGet("DateTime")]
        public DateTime Get() => _randomProvider.Get();
    }
}