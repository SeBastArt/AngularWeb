using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Models.WeatherForecast
{
    public class WeatherForecastPagedResultsModel
    {
        public ICollection<WeatherForecastModel> Results { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalNumberOfPages { get; set; }
        public int TotalNumberOfRecords { get; set; }
        public Uri NextPageUrl { get; set; }
    }
}
