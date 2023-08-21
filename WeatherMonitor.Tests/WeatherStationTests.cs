using AutoFixture;
using Moq;
using WeatherMonitor.src.Models;
using WeatherMonitor.src.Observable;

namespace WeatherMonitor.Tests
{
    public class WeatherStationTests
    {
        [Fact]
        public void Notify_MultipleObservers_AllUpdated()
        {
            //Arrange
            var obs1 = new Mock<src.Observers.IObserver<WeatherInfoModel>>();
            var obs2 = new Mock<src.Observers.IObserver<WeatherInfoModel>>();
            var weatherStation = new WeatherStation();

            weatherStation.Subscribe(obs1.Object);
            weatherStation.Subscribe(obs2.Object);
            var fixture = new Fixture();
            var weatherData = fixture.Create<WeatherInfoModel>();
            //Act
            weatherStation.Notify(weatherData);

            //Assert
            obs1.Verify(x => x.Update(weatherData));
            obs2.Verify(x => x.Update(weatherData));
        }
    }
}
