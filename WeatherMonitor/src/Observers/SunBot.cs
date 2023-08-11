using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherMonitor.src.Models;

namespace WeatherMonitor.src.Observers
{
    public class SunBot : BaseBot, IObserver<WeatherInfoModel>
    {

        [JsonPropertyName("temperatureThreshold")]
        public double TemperatureThreshold { get; set; }
        public void Update(WeatherInfoModel weatherData)
        {
            if(this.Enabled && weatherData.Temperature >  TemperatureThreshold)
            {
                Console.WriteLine(this.Message);
            }
        }
    }
}
