using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherMonitor.src.Models;

namespace WeatherMonitor.src.Observers
{
    public class SnowBot : BaseBot, IObserver<WeatherInfoModel>
    {
        [JsonPropertyName("temperatureThreshold")]
        public double TempertureThreshold { get; set; }
        public void Update(WeatherInfoModel weatherData)
        {
            if(this.Enabled && weatherData.Temperature < TempertureThreshold) { }
        }
    }
}
