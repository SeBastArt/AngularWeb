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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using AngularWeb.Models.WeatherForecast;
using AngularWeb.Models.Users;
using System.Net.Mime;

namespace AngularWeb.V2.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    [ApiController]
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


        /// <summary>
        /// returns the weatherforecasts for current user
        /// possibility for pagination
        /// if page is null then no pagination is given
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="ascending"></param>
        /// <response code="200">Returns all the weatherforecasts an the newly created one</response>
        /// <response code="401">Unauthorized</response>     
        [ProducesResponseType(typeof(WeatherForecastPagedResultsModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UnauthorizedUserModel), StatusCodes.Status401Unauthorized)]
        [HttpGet]
        public IActionResult GetAll(int? page = null, int pageSize = 10, string orderBy = nameof(AngularWeb.Entities.WeatherForecast.WeatherForecastId), bool ascending = true)
        {
            _diagnosticContext.Set("CatalogLoadTime", 1423);
            var currentUserId = long.Parse(User.Identity.Name, NumberStyles.Number, CultureInfo.InvariantCulture);
            var user = _context.Users.Find(currentUserId);
            var wf = new WeatherForecast { Date = DateTime.UtcNow, TemperatureC = 35, Summary = "neu", UserId = currentUserId };

            user.WeatherForecasts.Add(wf);
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
