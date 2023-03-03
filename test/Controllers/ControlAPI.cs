using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControlAPI : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ControlAPI> _logger;

        public ControlAPI(ILogger<ControlAPI> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<API> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new API
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        public IEnumerable<Models> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Models
            {
                Date =DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20,55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
            
        }
    }
}