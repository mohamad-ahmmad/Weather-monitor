
namespace WeatherMonitor.src.Observers
{
    public interface IObserver <T>
    {
        public void Update(T weatherData);
    }
}
