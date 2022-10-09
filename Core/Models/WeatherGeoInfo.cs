using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexWeatherAPI.Core.Models
{
    [DataContract]
    public class WeatherGeoInfo
    {
        [DataMember(Name = "district")]
        public WeatherDistrict District { get; set; }

        [DataMember(Name = "locality")]
        public WeatherLocality Locality { get; set; }

        [DataMember(Name = "province")]
        public WeatherProvince Province { get; set; }

        [DataMember(Name = "country")]
        public WeatherCountry Country { get; set; }

    }
}
