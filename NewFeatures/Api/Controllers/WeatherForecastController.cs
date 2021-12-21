using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Windy", "Balmy", "Hot", "Sweltering", "Scorching"    
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            try
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet(Name = "GetMyGreetings")]
        public IActionResult GetMyGreetings()
        {
            return Ok("Howdy Obi!");
        }

        //[HttpGet(Name = "GetEmployeeInfo")]
        //public Employee GetEmpInfo()
        //{
        //    var emp = new Employee { Id = 1, FirstName = "Obi", LastName = "Oberoi", Gender = 'M', Age = 40 };
        //    return emp;
        //}
    }
}