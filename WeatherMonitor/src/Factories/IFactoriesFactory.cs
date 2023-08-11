using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitor.src.Factories.BotsFactory;

namespace WeatherMonitor.src.Factories
{
    [Obsolete]
    public interface IFactoriesFactory
    {
        public IBotsFactory? CreateFactory(string fileContent);
    }
}
