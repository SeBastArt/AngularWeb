using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AngularWeb.Models;
using AngularWeb.Data;
using Serilog;
using Microsoft.AspNetCore.Authorization;
using AngularWeb.Entities;

namespace AngularWeb.V1.Controllers
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("0.9", Deprecated = true)]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDiagnosticContext _diagnosticContext;
        private readonly DataContext _context;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IDiagnosticContext diagnosticContext,
            DataContext context
        ){
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _diagnosticContext = diagnosticContext ?? throw new ArgumentNullException(nameof(diagnosticContext));
            _context = context;
           
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<WeatherForecast>), 200)]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogWarning("I dare you");
            _diagnosticContext.Set("CatalogLoadTime", 1423);
            var currentUserId = int.Parse(User.Identity.Name);
          
            var _WeatherForecast = new WeatherForecast { Date = DateTime.UtcNow, TemperatureC = 35, Summary = "neu" };
            _context.WeatherForecasts.Add(_WeatherForecast);
            _context.SaveChanges();
            return _context.WeatherForecasts;
        }
    }
}
