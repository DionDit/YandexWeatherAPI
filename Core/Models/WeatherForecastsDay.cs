using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexWeatherAPI.Core.Models
{
    [DataContract]
    public class WeatherForecastsDay
    {
        [DataMember(Name = "temp_avg")]
        public int Temperature { get; set; }

        [DataMember(Name = "feels_like")]
        public int PerceivedTemperature { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        public string IconUrl { get => $"https://yastatic.net/weather/i/icons/funky/dark/{Icon}.svg"; }

        [DataMember(Name = "condition")]
        private string condition { get; set; }
        public string Condition
        {
            get
            {
                var Result = string.Empty;
                switch (condition)
                {
                    case "clear":
                        Result = "Ясно";
                        break;
                    case "partly-cloudy":
                        Result = "Малооблачно";
                        break;
                    case "cloudy":
                        Result = "Облачно с прояснениями";
                        break;
                    case "overcast":
                        Result = "Пасмурно";
                        break;
                    case "drizzle":
                        Result = "Морось";
                        break;
                    case "light-rain":
                        Result = "Небольшой дождь";
                        break;
                    case "rain":
                        Result = "Дождь";
                        break;
                    case "moderate-rain":
                        Result = "Умеренно сильный дождь";
                        break;
                    case "heavy-rain":
                        Result = "Сильный дождь";
                        break;
                    case "continuous-heavy-rain":
                        Result = "Длительный сильный дождь";
                        break;
                    case "showers":
                        Result = "Ливень";
                        break;
                    case "wet-snow":
                        Result = "Дождь со снегом";
                        break;
                    case "light-snow":
                        Result = "Небольшой снег";
                        break;
                    case "snow":
                        Result = "Снег";
                        break;
                    case "snow-showers":
                        Result = "Снегопад";
                        break;
                    case "hail":
                        Result = "Град";
                        break;
                    case "thunderstorm":
                        Result = "Гроза";
                        break;
                    case "thunderstorm-with-rain":
                        Result = "Дождь с грозой";
                        break;
                    case "thunderstorm-with-hail":
                        Result = "Гроза с градом";
                        break;
                }
                return Result;
            }
        }

        [DataMember(Name = "wind_speed")]
        public double WindSpeed { get; set; }

        [DataMember(Name = "pressure_mm")]
        public double Pressure { get; set; }

        [DataMember(Name = "humidity")]
        public double Humidity { get; set; }

        [DataMember(Name = "cloudness")]
        private double cloudness { get; set; }
        public double Cloudness { get => cloudness * 100; }
        public override string ToString() => $"Температура: {Temperature}\nОщущается как: {PerceivedTemperature}\nИконка: {IconUrl}\nСостояние погоды: {Condition}\nСкорость ветра: {WindSpeed}\nДавление: {Pressure}\nВлажность: {Humidity}\nОблачность: {Cloudness}";

    }
}
