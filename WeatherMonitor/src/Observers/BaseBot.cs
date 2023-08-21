using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using WeatherMonitor.src.Writers;

namespace WeatherMonitor.src.Observers
{
    public abstract class BaseBot
    {

        [JsonPropertyName("message")]
        public string Message { get; set; } = "Defualt Message";

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = true;

        protected IWriter _writer;

        public BaseBot(IWriter writer)
        {
            _writer = writer;
        }

    }
}
