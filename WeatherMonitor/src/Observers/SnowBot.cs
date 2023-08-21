using System.Text.Json.Serialization;
using WeatherMonitor.src.Models;
using WeatherMonitor.src.Writers;

namespace WeatherMonitor.src.Observers
{
    public class SnowBot : BaseBot, IObserver<WeatherInfoModel>
    {
        public SnowBot(IWriter writer) : base(writer) { }


        [JsonPropertyName("temperatureThreshold")]
        public double TempertureThreshold { get; set; }

        public void Update(WeatherInfoModel weatherData)
        {
            if (this.Enabled && weatherData.Temperature < TempertureThreshold)
            {
                _writer.WriteLine(this.Message);
            }
        }
    }
}
