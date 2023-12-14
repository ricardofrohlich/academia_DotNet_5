using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    //https:www.google.com/xyz/ação
    //https:www.google.com/CONTROLLER/ENDPOINT
    //https:www.google.com/xyz/hello
    //https:www.google.com/xyz/hello/5
    [ApiController]
    [Route("xyz")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public string HelloWorld()
        {
            return "Hello world atos UFN 2023";
        }

        [HttpPost]
        [Route("hello/{idade}")]
        public string HelloWorldPost([FromBody] string nome, [FromRoute] int idade)
        {
            return "Hello world " + idade + " atos UFN 2023" + nome;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}