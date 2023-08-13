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
                    RainBot rainBot = JsonSerializer.Deserialize<RainBot>(kvp.Value.ToString());
                    observers.Add(rainBot);
                }
                else if(kvp.Key == "SnowBot")
                {
                    SnowBot snowBot = JsonSerializer.Deserialize<SnowBot>(kvp.Value.ToString());
                    observers.Add(snowBot);

                }
                else if(kvp.Key == "SunBot")
                {
                    SunBot sunBot = JsonSerializer.Deserialize<SunBot>(kvp.Value.ToString());
                    observers.Add(sunBot);
                }
                
                //Add more types here ...

            }

            return observers;
        }
    }
}
