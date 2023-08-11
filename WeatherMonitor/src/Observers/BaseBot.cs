using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
