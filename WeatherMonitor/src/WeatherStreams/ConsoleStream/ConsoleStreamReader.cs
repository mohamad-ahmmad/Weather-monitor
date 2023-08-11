using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitor.src.Models;

namespace WeatherMonitor.src.WeatherStreams.ConsoleStream
{
    public class ConsoleStreamReader 
    {
        private IWeatherInfoFactory _weatherInfoFactory;
        public ConsoleStreamReader(IWeatherInfoFactory factory)
        {
            _weatherInfoFactory = factory;
        }

        public WeatherInfoModel ReadFromConsole()
        {
            Console.WriteLine("Enter Data :");
            string consoleStream = Console.ReadLine();
            return _weatherInfoFactory.CreateWeatherInfo(consoleStream);
        }
    }
}
