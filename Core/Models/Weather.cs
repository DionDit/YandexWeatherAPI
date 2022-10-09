using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YandexWeatherAPI.Core.Models
{
    [DataContract]
    public class Weather
    {
        [DataMember(Name = "now_dt")]
        public string Time { get; set; }

        [DataMember(Name = "geo_object")]
        public WeatherGeoInfo GeoInfo { get; set; }

        [DataMember(Name = "fact")]
        public WeatherFact Fact { get; set; }

        [DataMember(Name = "forecasts")]
        public List<WeatherForecasts> Forecasts { get; set; }

        public static Weather CreateWeatherFromJSON(string WeatherJSON)
        {
            DataContractJsonSerializer Json = new DataContractJsonSerializer(typeof(Weather));
            using (MemoryStream MemoryStream = new MemoryStream(Encoding.Unicode.GetBytes(WeatherJSON)))
            {
                return Json.ReadObject(MemoryStream) as Weather;
            }
        }
    }
}
