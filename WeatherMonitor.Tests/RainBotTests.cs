using AutoFixture;
using Moq;
using WeatherMonitor.src.Models;
using WeatherMonitor.src.Observers;
using WeatherMonitor.src.Writers;

namespace WeatherMonitor.Tests
{
    public class RainBotTests
    {
        private Fixture _fixture;
        private Mock<IWriter> _writerMock;
        private RainBot _rainBot;
        private WeatherInfoModel _weatherInfo;

        public RainBotTests()
        {
            _fixture = new Fixture();
            _writerMock = new Mock<IWriter>();
            _rainBot = new RainBot(_writerMock.Object)
            {
                HumidityThreshold = 70,
                Message = "Message"
            };
            _weatherInfo = new WeatherInfoModel
            {
                Humidity = 71,
                Location = _fixture.Create<string>(),
                Temperature = _fixture.Create<double>(),
            };

        }

        [Fact]
        public void Update_EnabledAndHumidityExceedsThreshold_MessageWritten()
        {
            //Act
            _rainBot.Update(_weatherInfo);

            //Assert
            _writerMock.Verify(x => x.WriteLine(_rainBot.Message), Times.Once);
        }
        [Fact]
        public void Update_EnabledAndHumidityBelowThreshold_MessageWritten()
        {
            //Arrange
            _weatherInfo.Humidity = 69;
            //Act
            _rainBot.Update(_weatherInfo);

            //Assert
            _writerMock.Verify(x => x.WriteLine(_rainBot.Message), Times.Never);
        }
    }
}