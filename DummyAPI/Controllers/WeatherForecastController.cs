using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        /*

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        */

        //Posso configurare lo specifico percorso a cui dovr ispondere questo metodo
        [HttpGet]

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return new[] { new WeatherForecast { Summary = "Pippo", TemperatureC = 30 } };
        }
    
    }
}
