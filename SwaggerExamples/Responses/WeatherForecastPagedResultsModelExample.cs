using AngularWeb.Models;
using AngularWeb.Models.WeatherForecast;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;

namespace AngularWeb.SwaggerExamples.Responses
{
    public class WeatherForecastPagedResultsModelExample : IExamplesProvider<WeatherForecastPagedResultsModel>
    {
        public WeatherForecastPagedResultsModel GetExamples()
        {
            return new WeatherForecastPagedResultsModel
            {
                PageNumber = 1,
                PageSize = 10,
                TotalNumberOfPages = 10,
                TotalNumberOfRecords = 100,
                NextPageUrl = new Uri("https://localhost:5001/WeatherForecast/GetAll?page=2&pageSize=10&orderBy=WeatherForecastId&ascending=True"),
                Results = new List<WeatherForecastModel>
                {
                    new WeatherForecastModel { WeatherForecastId = 11, TemperatureC = 15, Date = new DateTime(2020, 12, 25, 10, 30, 50), Summary = "chilly" },
                    new WeatherForecastModel { WeatherForecastId = 12, TemperatureC = 23, Date = new DateTime(2020, 7, 25, 10, 30, 50), Summary = "warm" },
                }
            };
        }
    }
}
