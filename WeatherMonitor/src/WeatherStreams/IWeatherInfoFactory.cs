using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitor.src.Models;

namespace WeatherMonitor.src.WeatherStreams
{
    public interface IWeatherInfoFactory
    {
        public WeatherInfoModel CreateWeatherInfo(string dataStream);
    }
}
