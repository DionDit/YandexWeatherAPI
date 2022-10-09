using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YandexWeatherAPI.Core
{
    public static class YandexGeoCoder
    {
        public static (string, string) GetCoordinate(string City, string APIKey)
        {
            var Coordinate = (string.Empty, string.Empty);
            using (WebClient WebClient = new WebClient())
            {
                WebClient.Encoding = Encoding.UTF8;
                var Result = WebClient.DownloadString($"https://geocode-maps.yandex.ru/1.x/?apikey={APIKey}&geocode={City}");
                MatchCollection Point = Regex.Matches(Result, "<Point xmlns=\"http://www.opengis.net/gml\"><pos>(.*?)</pos></Point>");
                Coordinate.Item1 = Point[0].Groups[1].Value.Split(new char[] {' '})[1];
                Coordinate.Item2 = Point[0].Groups[1].Value.Split(new char[] {' '})[0];
            }
            return Coordinate;
        }
    }
}
