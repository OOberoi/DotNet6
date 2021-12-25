using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet(Name = "GetMyGreetings")]
        public IActionResult GetMyGreetings()
        {
            return Ok("Howdy Obi Oberoi!");
        }

        [HttpGet(Name = "GetEmployeeInfo")]
        public IEnumerable<Employee> Get()
        {
            var emp = new List<Employee>() { 
                new Employee()
                {
                Id = 1, FirstName = "Obi", LastName = "Oberoi", Gender = 'M', Age = 40
                }
            };
            return emp;
        }


        public IActionResult GetArrayList()
        { 
            return Ok();
        }
    }
}