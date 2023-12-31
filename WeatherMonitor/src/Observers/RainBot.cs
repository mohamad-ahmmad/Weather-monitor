﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherMonitor.src.Models;
using WeatherMonitor.src.Writers;

namespace WeatherMonitor.src.Observers
{
    public class RainBot : BaseBot, IObserver<WeatherInfoModel>
    {
        public RainBot(IWriter writer) : base(writer)
        {
        }



        [JsonPropertyName("humidityThreshold")]
        public double HumidityThreshold { get; set; }

        public void Update(WeatherInfoModel weatherData)
        {
            if (this.Enabled && this.HumidityThreshold < weatherData.Humidity)
            {
                _writer.WriteLine(this.Message);
            }
        }
    }
}
