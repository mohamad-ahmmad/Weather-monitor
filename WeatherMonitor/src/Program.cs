
using WeatherMonitor.src.Factories.BotsFactory;
using WeatherMonitor.src.Models;
using WeatherMonitor.src.Observable;
using WeatherMonitor.src.WeatherStreams;
using WeatherMonitor.src.WeatherStreams.ConsoleStream;

namespace WeatherMonitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string configFileContent = File.ReadAllText("config.json");

            IBotsFactory factory = new JsonBotsFactory();
            var bots = factory.CreateBots(configFileContent);

            src.Observable.IObservable<WeatherInfoModel> weatherStation = new WeatherStation(bots);

            var consoleReader = new ConsoleStreamReader(new WeatherInfoFactory());

            while (true)
            {
                var weatherInfo = consoleReader.ReadFromConsole();
                weatherStation.Notify(weatherInfo);
            }

        }
    }
}