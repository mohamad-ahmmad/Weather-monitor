using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitor.src.Models;
using WeatherMonitor.src.Observers;

namespace WeatherMonitor.src.Factories.BotsFactory
{
    public interface IBotsFactory
    {
        public List<Observers.IObserver<WeatherInfoModel>> CreateBots(string fileContent);
    }
}
