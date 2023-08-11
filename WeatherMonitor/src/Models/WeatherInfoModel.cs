using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherMonitor.src.Models
{
    [XmlRoot("WeatherData")]
    public class WeatherInfoModel 
    {
        [JsonPropertyName("Location")]
        [XmlElement("Location")]
        public string Location { get; set; }

        [JsonPropertyName("Temperature")]
        [XmlElement("Temperature")]
        public double Temperature { get; set; }

        [JsonPropertyName("Humidity")]
        [XmlElement("Humidity")]
        public double Humidity { get; set; }

    }

}
