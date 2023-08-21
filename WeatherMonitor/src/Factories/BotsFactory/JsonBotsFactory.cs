using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using WeatherMonitor.src.Models;
using WeatherMonitor.src.Observers;
using WeatherMonitor.src.Writers;

namespace WeatherMonitor.src.Factories.BotsFactory
{
    public class JsonBotsFactory : IBotsFactory
    {

        

        public List<Observers.IObserver<WeatherInfoModel>> CreateBots(string fileContent)
        {
            List<Observers.IObserver<WeatherInfoModel>> observers = new();
            
            var data = JsonSerializer.Deserialize<Dictionary<string, object>>(fileContent);            
            foreach(var kvp in data)
            {

                if(kvp.Key == "RainBot")
                {
                    var rainBotProperites = JsonSerializer.Deserialize<Dictionary<string, object>>(kvp.Value.ToString());

                    var rainBot = new RainBot(Program.Writer)
                    {
                        Message = rainBotProperites["message"].ToString(),
                        Enabled = bool.Parse(rainBotProperites["enabled"].ToString()),
                        HumidityThreshold = double.Parse(rainBotProperites["humidityThreshold"].ToString()),
                    };
                    observers.Add(rainBot);
                }
                else if (kvp.Key == "SnowBot")
                {
                    var snowBotProperites = JsonSerializer.Deserialize<Dictionary<string, object>>(kvp.Value.ToString());

                    var snowBot = new SnowBot(Program.Writer)
                    {
                        Message = snowBotProperites["message"].ToString(),
                        Enabled = bool.Parse(snowBotProperites["enabled"].ToString()),
                        TempertureThreshold = double.Parse(snowBotProperites["temperatureThreshold"].ToString()),
                    };
                    observers.Add(snowBot);
                }
                else if (kvp.Key == "SunBot")
                {
                    var sunBotProperites = JsonSerializer.Deserialize<Dictionary<string, object>>(kvp.Value.ToString());

                    var sunBot = new SunBot(Program.Writer)
                    {
                        Message = sunBotProperites["message"].ToString(),
                        Enabled = bool.Parse(sunBotProperites["enabled"].ToString()),
                        TemperatureThreshold = double.Parse(sunBotProperites["temperatureThreshold"].ToString()),
                    };
                    observers.Add(sunBot);
                }

                //Add more types here ...

            }

            return observers;
        }
    }
}
