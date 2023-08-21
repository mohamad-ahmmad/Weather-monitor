using System.Text.Json.Serialization;
using WeatherMonitor.src.Models;
using WeatherMonitor.src.Writers;

namespace WeatherMonitor.src.Observers
{
    public class SunBot : BaseBot, IObserver<WeatherInfoModel>
    {
        public SunBot(IWriter writer) : base(writer)
        {
        }

        [JsonPropertyName("temperatureThreshold")]
        public double TemperatureThreshold { get; set; }
        public void Update(WeatherInfoModel weatherData)
        {
            if(this.Enabled && weatherData.Temperature >  TemperatureThreshold)
            {
                _writer.WriteLine(this.Message);
            }
        }
    }
}
