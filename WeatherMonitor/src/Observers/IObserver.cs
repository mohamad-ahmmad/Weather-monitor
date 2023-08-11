using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitor.src.Models;

namespace WeatherMonitor.src.Observers
{
    public interface IObserver <T>
    {
        public void Update(T weatherData);
    }
}
