using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers;

[Route("controller")]
[ApiController]
public class Controller1 : Controller
{
    private readonly ILoggerManager _logger;

    public Controller1(ILoggerManager logger)
    {
        _logger = logger;
    }

    // GET
    [HttpGet]
    public IEnumerable<string> Index()
    {
        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");
        return new[] { "value1", "value2" };
    }
}