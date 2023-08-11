using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitor.src.Factories.BotsFactory;

namespace WeatherMonitor.src.Factories
{
    [Obsolete]
    public class FactoriesFactory : IFactoriesFactory
    {

        /// <summary>
        /// Create a proper based on the format factory to create bots.
        /// </summary>
        /// <param name="fileContent"></param>
        /// <returns>Factory object or null if the format unknown</returns>
        public IBotsFactory CreateFactory(string fileContent)
        {
            IBotsFactory botsFactory = null;

            if (fileContent.StartsWith("{")) 
            {
                botsFactory = new JsonBotsFactory();
            }
            
            return botsFactory;
        }
    }
}
