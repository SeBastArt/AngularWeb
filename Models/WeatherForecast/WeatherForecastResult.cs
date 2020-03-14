using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Models
{
    public class WeatherForecastResult
    {
        public IEnumerable<WeatherForecastModel> Results { get; set; }
    }
}
