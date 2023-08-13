using System.Text.Json;
using System.Xml.Serialization;
using WeatherMonitor.src.Models;

namespace WeatherMonitor.src.WeatherStreams
{
    public static class FactoryUtilis
    {

        public static WeatherInfoModel ParseJson(string weatherInfo)
            => JsonSerializer.Deserialize<WeatherInfoModel>(weatherInfo);
        
        public static WeatherInfoModel ParseXml(string weatherInfo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(WeatherInfoModel));
            WeatherInfoModel weatherObj;

            using (TextReader reader = new StringReader(weatherInfo))
            {
                 weatherObj = (WeatherInfoModel)serializer.Deserialize(reader);
            }

            return weatherObj;
        }
        

    }
}
