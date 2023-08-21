using WeatherMonitor.src.Models;


namespace WeatherMonitor.src.Observable
{
    public class WeatherStation : IObservable<WeatherInfoModel>
    {
        private List<Observers.IObserver<WeatherInfoModel>> _observers;

        public WeatherStation(List<Observers.IObserver<WeatherInfoModel>> bots)
        {
            _observers = bots;
        }
        public WeatherStation()
        {
            _observers = new List<Observers.IObserver<WeatherInfoModel>>();
        }
        public void Notify(WeatherInfoModel data)
        {
            _observers.ForEach(o => o.Update(data));
        }

        public void Subscribe(Observers.IObserver<WeatherInfoModel> bot)
        {
            _observers.Add(bot);
        }
    }
}
