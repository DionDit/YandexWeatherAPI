using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexWeatherAPI.Core.Models
{
    [DataContract]
    public class WeatherForecasts
    {
        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "parts")]
        public WeatherForecastsParts Parts { get; set; }
    }
}
