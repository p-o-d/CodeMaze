using System.Collections.Generic;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogDebug("This is Debug message.");
            _logger.LogError("This is Error message.");
            _logger.LogWarning("This is Warning message.");
            _logger.LogInfo("This is Info message.");

            return new [] {"str1", "str2"};
        }
    }
}
