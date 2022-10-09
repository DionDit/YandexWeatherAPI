using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using YandexWeatherAPI.Core.Models;

namespace YandexWeatherAPI.Core
{
    [DataContract]
    public class YandexWeather
    {
        private string APIKeyWeather { get; set; }
        private string APIKeyGeoCoder { get; set; }
        private string City { get; set; }

        [DataMember]
        public Weather Weather { get; set; }
        public YandexWeather(string APIKeyWeather, string APIKeyGeoCoder, string City)
        {
            this.APIKeyWeather = APIKeyWeather;
            this.APIKeyGeoCoder = APIKeyGeoCoder;
            this.City = City;
            using (WebClient WebClient = new WebClient())
            {
                WebClient.Encoding = Encoding.UTF8;
                WebClient.Headers.Add("X-Yandex-API-Key", APIKeyWeather);
                var Coordinate = YandexGeoCoder.GetCoordinate(City, APIKeyGeoCoder);
                this.Weather = Weather.CreateWeatherFromJSON(WebClient.DownloadString($"https://api.weather.yandex.ru/v2/forecast?lat={Coordinate.Item1}&lon={Coordinate.Item2}&extra=true"));
            }
        }
    }
}
