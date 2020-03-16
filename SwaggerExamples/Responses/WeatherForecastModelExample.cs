using AngularWeb.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.SwaggerExamples.Responses
{
    public class WeatherForecastModelExample : IExamplesProvider<WeatherForecastModel>
    {
        public WeatherForecastModel GetExamples()
        {
            return new WeatherForecastModel
            {
                WeatherForecastId = 12,
                Date = new DateTime(2020, 12, 25, 10, 30, 50),
                TemperatureC = 15,
                Summary = "chilly"
            };
        }
    }
}
