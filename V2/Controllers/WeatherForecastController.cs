using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AngularWeb.Models;
using AngularWeb.Data;
using Serilog;
using AngularWeb.Entities;
using Microsoft.AspNetCore.Authorization;
using AngularWeb.V2.Controllers;
using AutoMapper;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace AngularWeb.V2.Controllers
{
    [Authorize]
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    public class WeatherForecastController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDiagnosticContext _diagnosticContext;
        private readonly DataContext _context;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IMapper mapper,
            IDiagnosticContext diagnosticContext,
            DataContext context
        ) : base(mapper)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _diagnosticContext = diagnosticContext ?? throw new ArgumentNullException(nameof(diagnosticContext));
            _context = context;
           
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<WeatherForecast>), 200)]
        public IActionResult GetAll(int? page = null, int pageSize = 10, string orderBy = nameof(AngularWeb.Entities.WeatherForecast.WeatherForecastId), bool ascending = true)
        {
            _logger.LogWarning("I dare you");
            _diagnosticContext.Set("CatalogLoadTime", 1423);
            var currentUserId = long.Parse(User.Identity.Name, NumberStyles.Number, CultureInfo.InvariantCulture);
            var user = _context.Users.Find(currentUserId);
            var wf = new WeatherForecast { Date = DateTime.UtcNow, TemperatureC = 35, Summary = "neu" };

            //_context.WeatherForecast.Add(wf);
            user.WeatherForecasts.Add(wf);
            //var _WeatherForecast = new WeatherForecast { Date = DateTime.UtcNow, TemperatureC = 35, Summary = "neu" };

            //_context.WeatherForecast.Add(_WeatherForecast);
            _context.SaveChanges();
            
            if (page == null)
            {
                var test = _context.Users.Include(user => user.WeatherForecasts).SingleOrDefault(x => x.Id == currentUserId);
                return Ok(new WeatherForecastResult{
                    Results = _mapper.Map<List<WeatherForecastModel>>(test.WeatherForecasts.ToList())
                });
            }

            var pagedUsers = CreatePagedResults<WeatherForecast, WeatherForecastModel>
                (_context.WeatherForecasts.Where(s => s.TemperatureC > 0), page.Value, pageSize, orderBy, ascending);
            return Ok(pagedUsers);
        }
    }
}
