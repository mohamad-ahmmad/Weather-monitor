using WeatherMonitor.src.Models;

namespace WeatherMonitor.src.WeatherStreams
{
    public class WeatherInfoFactory : IWeatherInfoFactory
    {

        public WeatherInfoModel CreateWeatherInfo(string dataStream)
        {
            WeatherInfoModel data;

            if (string.IsNullOrWhiteSpace(dataStream))
                data = null;
            else if (dataStream.StartsWith("{"))
                data = FactoryUtilis.ParseJson(dataStream);
            else if (dataStream.StartsWith("<"))
                data = FactoryUtilis.ParseXml(dataStream);
            else
                data = null;

            return data;
        }
    }
}
