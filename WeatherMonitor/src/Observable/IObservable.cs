
namespace WeatherMonitor.src.Observable
{
    public interface IObservable<T>
    {

        public void Subscribe(Observers.IObserver<T> bot);
        public void Notify(T data);

    }
}
