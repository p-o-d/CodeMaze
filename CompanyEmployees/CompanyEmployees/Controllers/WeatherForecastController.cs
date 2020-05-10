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
        private readonly IRepositoryManager _repositoryManager;

        public WeatherForecastController(ILoggerManager logger, IRepositoryManager repositoryManager)
        {
            _logger = logger;
            _repositoryManager = repositoryManager;
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
