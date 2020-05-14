using Contracts;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public ErrorController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [Route("/error")]
        public IActionResult Error()
        {
            var contextFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
            if (contextFeature != null)
            {
                _logger.LogError($"{contextFeature.Error}");
                return Problem(statusCode: StatusCodes.Status500InternalServerError);
            }

            return NotFound();
        }
    }
}