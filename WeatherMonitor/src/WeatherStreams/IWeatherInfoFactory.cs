using WeatherMonitor.src.Models;

namespace WeatherMonitor.src.WeatherStreams
{
    public interface IWeatherInfoFactory
    {
        public WeatherInfoModel CreateWeatherInfo(string dataStream);
    }
}
