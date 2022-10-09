using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexWeatherAPI.Core.Models
{
    [DataContract]
    public class WeatherForecastsParts
    {
        [DataMember(Name = "day")]
        public WeatherForecastsDay Fact { get; set; }
    }
}
