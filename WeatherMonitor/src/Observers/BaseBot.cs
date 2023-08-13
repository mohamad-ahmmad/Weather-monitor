using System.Text.Json.Serialization;

namespace WeatherMonitor.src.Observers
{
    public abstract class BaseBot
    {

        [JsonPropertyName("message")]
        public string Message { get; set; } = "Defualt Message";

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = true;

    }
}
